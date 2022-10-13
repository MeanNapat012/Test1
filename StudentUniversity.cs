public class StudentUniversity : Persons
{
    public string StudentUniversityID;
    public bool CheckStudent;
    public string EmailStudent;
    public string PasswordStudent;
    public StudentUniversity(string Nameprefix, string Name, string Surname,string StudentUniversityID,double Age,string Allergy, string Religion,bool CheckStudent,string EmailStudent,string PasswordStudent) : base(Nameprefix,Name,Surname,Age,Allergy,Religion )
    {
        this.StudentUniversityID = StudentUniversityID;
        this.CheckStudent = false;
        this.EmailStudent = EmailStudent;
        this.PasswordStudent = PasswordStudent;
    }
    public string GetEmailStudent()
    {
        return this.EmailStudent;
    }
    public string GetPasswordStudent()
    {
        return this.PasswordStudent;
    }
}