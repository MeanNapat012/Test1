public class Teacher : Persons
{
    public string Rank;
    public string CarNum;
    public string EmailTeacher;
    public string PasswordTeacher;
    public bool Check;
    
    

    public Teacher(string Nameprefix, string Name, string Surname,double Age, string Rank, string Allergy,string Religion,string CarNum,bool Check,string EmailTeacher,string PasswordTeacher) : base(Nameprefix,Name,Surname,Age,Allergy,Religion)
    {
        this.Rank = Rank;
        this.CarNum = CarNum;
        this.EmailTeacher = EmailTeacher;
        this.PasswordTeacher = PasswordTeacher;
        this.Check = false;
        
    }
    public string GetEmailTeacher()
    {
        return this.EmailTeacher;
    }
    public string GetPasswordTeacher()
    {
        return this.PasswordTeacher;
    }

}