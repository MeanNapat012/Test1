
enum MenuRegister{ RegisterEvent = 1, ShowAllRegister = 2, SignIn = 3}
enum MenuLogin{ RegisterEvent = 1, showAllDataStudentUniversity = 2,showAllDataStudentSchool = 3,showAllDataTeacher = 4, Exit = 5}

class Program
{
    static PersonList personList;
    public static void Main(string[] args)
    {
        PersonListInprogram();
        PrintMenuRegisterScrene();
    }
    public static void PersonListInprogram()
    {
        Program.personList = new PersonList();
    }
    public static void PrintMenuRegisterScrene()
    {
        Console.Clear();
        PrintisMenuRegisterMenu();
        InputMenuRegister();
    }
    

    public static void PrintisMenuRegisterMenu()
    {
        Console.WriteLine("Welcome to Register IdeaCamp");
        Console.WriteLine("********************************");
        Console.WriteLine("1.Register event");
        Console.WriteLine("2.Show all person in Event");
        Console.WriteLine("3.sign In");
        Console.WriteLine("********************************");
    }   
    public static void InputMenuRegister()
    {
        Console.Write("Please input Menu : ");
        MenuRegister menuRegister = (MenuRegister)(int.Parse(Console.ReadLine()));
        PrsentMenuRegister(menuRegister);
    }
    public static void PrsentMenuRegister(MenuRegister menuRegister)
    {
        switch(menuRegister)
        {
            case MenuRegister.RegisterEvent :
                ShowInputRegisterInIdeaCamp();
                break;
            case MenuRegister.ShowAllRegister :
                ShowAllRegisterInIdeaCamp();
                break;
            case MenuRegister.SignIn :
                ShowSignInIdeaCamp();
                break;
            default:
                break;
        }
    }
    public static void PrintMenuLoginScene()
    {
        Console.Clear();
        PrintMenuLogin();
        InputMenuLogin();
    }
    public static void ShowAllRegisterInIdeaCamp()
    {
        Console.WriteLine("Teacher count : {0}", personList.NumberTeacher());
        Console.WriteLine("StudentUniversity count : {0}", personList.NumberStudentUniversity());
        Console.WriteLine("Student School M4 : {0}", personList.NumberStudentSchoolM_4());
        Console.WriteLine("Student School M5 : {0}", personList.NumberStudentSchoolM_5());
        Console.WriteLine("Student School M6 : {0}", personList.NumberStudentSchoolM_6());
        Console.ReadLine();
        PrintMenuRegisterScrene();
    }
    public static void PrintMenuLogin()
    {
        Console.WriteLine("Welcome to administrator IdeaCamp");
        Console.WriteLine("********************************");
        Console.WriteLine("1.Register event");
        Console.WriteLine("2.Show all data Student in University");
        Console.WriteLine("3.Show all data Student in School");
        Console.WriteLine("4.Show all data Teacher");
        Console.WriteLine("5.Log out");
        Console.WriteLine("********************************");
    }
    public static void InputMenuLogin()
    {
        Console.Write("Please input Menu : ");
        MenuLogin menutwo = (MenuLogin)(int.Parse(Console.ReadLine()));
        PrsentMenuLogin(menutwo);
    }
     public static void PrsentMenuLogin(MenuLogin menutwo)
    {
        switch(menutwo)
        {
            case MenuLogin.RegisterEvent :
                ShowInputRegisterInIdeaCamp();
                break;
            case MenuLogin.showAllDataStudentUniversity :
                ShowAllDataStudentUnitversity();
                break;
            case MenuLogin.showAllDataStudentSchool :
                ShowAllDataStudentSchool();
                break;
            case MenuLogin.showAllDataTeacher :
                ShowAllDataTeacher();
                break;
            case MenuLogin.Exit:
                Logout();
                break;
            default:
                break;
        }
    }
    public static void ShowInputRegisterInIdeaCamp()
    {
        Console.Clear();
        Console.WriteLine("Types of registered attendees");
        Console.WriteLine("********************************");
        Console.WriteLine("1.Student in University");
        Console.WriteLine("2.Student in School");
        Console.WriteLine("3.Teacher");
        Console.WriteLine("********************************");
        InputTypeRegister();
    }
    public static void ShowAllDataStudentUnitversity()
    {
        Console.Clear();
        Program.personList.FetchStudentUniversity();
        Console.ReadLine();
        PrintMenuLoginScene();
    }
    public static void ShowAllDataStudentSchool()
    {
        Console.Clear();
        Program.personList.FetchStudentSchool();
        Console.ReadLine();
        PrintMenuLoginScene();
    }
    public static void ShowAllDataTeacher()
    {
        Console.Clear();
        Program.personList.FetchTeacher();
        Console.ReadLine();
        PrintMenuLoginScene();
    }
    
    public static void InputTypeRegister()
    {
        Console.Write("Please input Type : ");
        int Type = int.Parse(Console.ReadLine());
        if(Type == 1)
        {
            InputNewRegisterStudentUniversityFromKeyboard();
        }
        else if(Type == 2)
        {
            InputNewRegisterStudentSchoolFromKeyboard();
        }
        else if(Type == 3)
        {
            InputNewRegisterTeacherFromKeyboard();
        }
    }
    public static void ShowSignInIdeaCamp()
    {
        Console.Clear();
        Console.WriteLine("****************************************");
        Console.WriteLine("Please Login");
        Console.Write("Email (Exit/exit) : ");
        string Emailname = Console.ReadLine();
        Console.Write("Password (Exit/exit) : ");
        string Passwordname = Console.ReadLine();
        Console.WriteLine("****************************************");
        if(personList.CheckCorrectEmailorPassword(Emailname, Passwordname))
        {
            PrintMenuLoginScene();
        }
        else if(Emailname == "Exit" || Emailname == "exit" && Passwordname == "Exit" || Passwordname == "exit")
        {
            PrintMenuRegisterScrene();
        }
        else
        {
            Console.WriteLine("Don't correct Email and Password. Please Try again!!!!");
            Console.ReadLine();
            ShowSignInIdeaCamp();
        }

    }
    public static void Logout()
    {
        PrintMenuRegisterScrene();
    }
    public static void InputNewRegisterStudentUniversityFromKeyboard()
    {
        Console.Clear();
        bool Administrator;
        Console.WriteLine("Register New Student in University");
        Console.WriteLine("****************************************");
        StudentUniversity studentUniversity = new StudentUniversity(InputNameprefix(), InputName(), InputSurname(),InputStudentUniersityID(), InputAge(),InputAllergy(), InputReligion(), Administrator = InputAdministor(), InputEmail(Administrator), InputPassword(Administrator));
        StudentUniversity CheckErrr = personList.Check(studentUniversity);
        if(CheckErrr != null)
        {
            Program.personList.AddNewPerson(studentUniversity);
            PrintMenuRegisterScrene();
        }
        Console.WriteLine("Look User and Username is already register.Please try again!!!!");
        Console.ReadLine();
        InputNewRegisterStudentUniversityFromKeyboard();

    }
    public static void InputNewRegisterStudentSchoolFromKeyboard()
    {
        Console.Clear();
        Console.WriteLine("Register New Student in School");
        Console.WriteLine("****************************************");
        StudentSchool studentSchool = new StudentSchool(InputNameprefix(), InputName(), InputSurname(), InputAge(), InputLevelEducation(),InputAllergy(),InputReligion(),InputSchool());
        StudentSchool CheckErrr = personList.Check(studentSchool);
        if(CheckErrr != null){
            Program.personList.AddNewPerson(studentSchool);
            PrintMenuRegisterScrene();
        }
        Console.WriteLine("Look User and Username is already register.Please try again!!!!");
        Console.ReadLine();
        InputNewRegisterStudentSchoolFromKeyboard();

    }
    public static void InputNewRegisterTeacherFromKeyboard()
    {
        Console.Clear();
        bool Administrator;
        Console.WriteLine("Register teacher");
        Console.WriteLine("****************************************");
        Teacher teacher = new Teacher(InputNameprefix(), InputName(), InputSurname(), InputAge(), InputRank(), InputAllergy(), InputReligion(), InputCarNum(),Administrator = InputAdministor(), InputEmail(Administrator), InputPassword(Administrator));
        Teacher CheckErrr = personList.Check(teacher);
        if(CheckErrr != null){
            Program.personList.AddNewPerson(teacher);
            PrintMenuRegisterScrene();
        }
        Console.WriteLine("Look User and Username is already register.Please try again!!!!");
        Console.ReadLine();
        InputNewRegisterTeacherFromKeyboard();
    }
    
    static string InputNameprefix()
    {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("1.Mr.");
        Console.WriteLine("2.Mrs");
        Console.WriteLine("3.Miss");
        Console.Write("NamePrefix : ");
        int Prefix = int.Parse(Console.ReadLine());
        Console.WriteLine("--------------------------------------");
        if(Prefix == 1)
        {
            return "Mr.";
        }
        else if(Prefix == 2){
            return "Mrs.";
        }
        else{
            return "Miss.";
        }
        
    }
    static string InputName()
    {
        Console.Write("Name : ");
        return Console.ReadLine();
    }
    static string InputSurname()
    {
        Console.Write("Surname : ");
        return Console.ReadLine();
    }
    static string InputStudentUniersityID()
    {
        Console.Write("StudentUniersityID : ");
        return Console.ReadLine();
    }
    static int InputAge()
    {
        Console.Write("Age : ");
        return int.Parse(Console.ReadLine());
    } 
    static string InputAllergy()
    {
        Console.Write("Allergy : ");
        return Console.ReadLine();
    }
    static string InputReligion()
    {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("1.Buddhist");
        Console.WriteLine("2.Christ");
        Console.WriteLine("3.Islam");
        Console.WriteLine("4.Other");
        Console.Write("Religion : ");
        int Religion = int.Parse(Console.ReadLine());
        Console.WriteLine("--------------------------------------");
        if(Religion == 1)
        {
            return "Buddhist";
        }
        else if(Religion == 2){
            return "Christ";
        }
        else if(Religion == 3){
            return "Islam";
        }
        else{
            return "Other";
        }
    }
    static string InputLevelEducation()
    {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("1.M/4");
        Console.WriteLine("2.M/5");
        Console.WriteLine("3.M/6");
        Console.Write("LeveL : ");
        int Level = int.Parse(Console.ReadLine());
        Console.WriteLine("--------------------------------------");
        if(Level == 1)
        {
            return "M/4";
        }
        else if(Level == 2){
            return "M/5";
        }
        else{
            return "M/6";
        }
    }
    static string InputSchool()
    {
        Console.Write("School : ");
        return Console.ReadLine();
    }
    static string InputRank()
    {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("1.dean");
        Console.WriteLine("2.head of department");
        Console.WriteLine("3.full-time teacher");
        Console.Write("Rank : ");
        int Rank = int.Parse(Console.ReadLine());
        Console.WriteLine("--------------------------------------");
        if(Rank == 1)
        {
            return "dean";
        }
        else if(Rank == 2)
        {
            return "head of department";
        }
        else
        {
            return "full-time teacher";
        }
    }
    static string InputCarNum()
    {
        
        Console.Write("Do you have car?(Y/N) : ");
        string x = Console.ReadLine();
        if(x == "Y"||x == "y")
        {
            Console.Write("Car number : ");
            return Console.ReadLine();
        }
        else if(x == "N" || x =="n")
        {
            return null;
        }
        else
        {
            Console.WriteLine("Please try again");
            return InputCarNum();
        }
    }
    static bool InputAdministor()
    {
        Console.Write("Are you an administrator?(Y/N) : ");
        string y = Console.ReadLine();
        if(y == "Y" || y == "y")
        {
            return true;      
        }
        else if(y == "N" || y == "n")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Please try again");
            return InputAdministor();
        }
    }
    static string InputEmail(bool Administrator)
    {
        if(Administrator == true)
        {
            Console.Write("Email : ");
            return Console.ReadLine();
        }
        return null;
    }
    static string InputPassword(bool Administrator)
    {
        if(Administrator == true)
        {
            Console.Write("Password : ");
            return Console.ReadLine();
        }
        return null;
    }
}