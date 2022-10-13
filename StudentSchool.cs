public class StudentSchool : Persons
{
    private string  LevelEducation;
    private string  School;

    public StudentSchool(string Nameprefix, string Name, string Surname,double Age,string LevelEducation,string Allergy, string Religion, string School ) : base(Nameprefix,Name,Surname,Age,Allergy,Religion )
    {
        this.LevelEducation = LevelEducation;
        this.School = School;
    }
    public string GetLevelEducation(){
        return this.LevelEducation;
    }
    
}