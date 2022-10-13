public class Persons
{
    private string Nameprefix;
    private string Name;
    private string Surname;
    private double Age;
    private string Allergy;
    private string Religion;

    public Persons(string Nameprefix, string Name, string Surname,double Age, string Religion,string Allergy )
    {
        this.Nameprefix = Nameprefix;
        this.Name = Name;
        this.Surname = Surname;
        this.Age = Age;
        this.Allergy = Allergy;
        this.Religion = Religion;

    }
    public string GetNameprefix()
    {
        return this.Nameprefix;
    }
    public string GetName()
    {
        return this.Name;
    }
    public string GetSurname()
    {
        return this.Surname;
    }
    public double GetAge()
    {
        return this.Age;
    }
    public string GetAllergy()
    {
        return this.Allergy;
    }
    public string GetReligion()
    {
        return this.Religion;
    }
}