using System.Collections.Generic;
using System;

public class PersonList
{
    private List<Persons> personList;
    public PersonList()
    {
        this.personList = new List<Persons>();
    }
    public void AddNewPerson(Persons persons)
    {
        this.personList.Add(persons);
    }
    public StudentSchool Check(StudentSchool CheckInfo)
    {
        
        if(personList is StudentSchool){
        foreach(StudentSchool studentSchool in personList){
            string NamePrefix = CheckInfo.GetNameprefix();
            string Name = CheckInfo.GetName();
            string Surname = CheckInfo.GetSurname();
            if(studentSchool.GetNameprefix().Equals(NamePrefix)&&studentSchool.GetName().Equals(Name)&&studentSchool.GetSurname().Equals(Surname)){
                return null;
            }
        }
        }return CheckInfo;
        
    }
    public StudentUniversity Check(StudentUniversity CheckInfo)
    {
        if(personList is StudentUniversity){
        foreach(StudentUniversity studentUniversity in personList){
            string NamePrefix = CheckInfo.GetNameprefix();
            string Name = CheckInfo.GetName();
            string Surname = CheckInfo.GetSurname();
            if(studentUniversity.GetNameprefix().Equals(NamePrefix)&&studentUniversity.GetName().Equals(Name)&&studentUniversity.GetSurname().Equals(Surname)){
                return null;
            }
        }
        }return CheckInfo;
    }
 public Teacher Check(Teacher CheckInfo)
    {
        if(personList is Teacher){
        foreach(Teacher teacher in personList){
            string NamePrefix = CheckInfo.GetNameprefix();
            string Name = CheckInfo.GetName();
            string Surname = CheckInfo.GetSurname();
            if(teacher.GetNameprefix().Equals(NamePrefix)&&teacher.GetName().Equals(Name)&&teacher.GetSurname().Equals(Surname)){
                return null;
            }
        }
        }return CheckInfo;
        
    }
    public void FetchStudentUniversity()
    {
        Console.WriteLine("List Student in University");
        Console.WriteLine("---------------------------------------");
        foreach(Persons persons in this.personList){
            if(persons is StudentUniversity){
                Console.WriteLine("NamePrefix : {0} / Name : {1} / Surname : {2}", persons.GetNameprefix(),persons.GetName(),persons.GetSurname());
            }
        }
        
    }
    public void FetchStudentSchool()
    {
        Console.WriteLine("List Student in School");
        Console.WriteLine("---------------------------------------");
        foreach(Persons persons in this.personList){
            if(persons is StudentSchool){
                Console.WriteLine("NamePrefix : {0} / Name : {1} / Surname : {2}", persons.GetNameprefix(),persons.GetName(),persons.GetSurname());
            }
            
        }
        
    }
    public void FetchTeacher()
    {
        Console.WriteLine("List Teacher");
        Console.WriteLine("---------------------------------------");
        foreach(Persons persons in this.personList){
            if(persons is Teacher){
                Console.WriteLine("NamePrefix : {0} / Name : {1} / Surname : {2}", persons.GetNameprefix(),persons.GetName(),persons.GetSurname());
            }
            
        }
        
    }
    public bool CheckCorrectEmailorPassword(string Emailname,string Passwordname)
    {
        
        foreach(StudentUniversity studentUniversity in personList){
            if(Emailname == studentUniversity.GetEmailStudent() && Passwordname == studentUniversity.GetPasswordStudent())
            {
                return true;
            }

        
        }
        return false;
        
        foreach(Teacher teacher in personList){
            if(Emailname == teacher.GetEmailTeacher() && Passwordname == teacher.GetPasswordTeacher()){
                return true;
            }
        }
        
        return false;
    }
    
    public int NumberTeacher()
    {
        int CountTeacher = 0;
        foreach(Persons persons in personList){
            if(personList is Teacher){
                CountTeacher = CountTeacher + 1;
            }
        }
        return CountTeacher;
    }
    public int NumberStudentUniversity()
    {
        int CountStudentUniversity = 0;
        foreach(Persons persons in personList){
            if(personList is StudentUniversity){
                CountStudentUniversity = CountStudentUniversity + 1;
            }
        }
        return CountStudentUniversity;
    }
    public int NumberStudentSchoolM_4()
    {
        int CountStudentSchoolM_4 = 0;
        foreach(Persons persons in personList){
            if(persons is StudentSchool studentSchool){
                if(studentSchool.GetLevelEducation() == "M/4"){
                    CountStudentSchoolM_4 = CountStudentSchoolM_4 + 1;
                }
            }
        }
        return CountStudentSchoolM_4;
    }
    public int NumberStudentSchoolM_5()
    {
        int CountStudentSchoolM_5 = 0;
        foreach(Persons persons in personList){
            if(persons is StudentSchool studentSchool){
                if(studentSchool.GetLevelEducation() == "M/5"){
                    CountStudentSchoolM_5 = CountStudentSchoolM_5 + 1;
                }
            }
        }
        return CountStudentSchoolM_5;
    }
    public int NumberStudentSchoolM_6()
    {
        int CountStudentSchoolM_6 = 0;
        foreach(Persons persons in personList){
            if(persons is StudentSchool studentSchool){
                if(studentSchool.GetLevelEducation() == "M/6"){
                    CountStudentSchoolM_6 = CountStudentSchoolM_6 + 1;
                }
            }
        }
        return CountStudentSchoolM_6;
    }
    
}