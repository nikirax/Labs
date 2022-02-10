#region Laba 1
//var TeacherVasa = new Teacher() { Name = "Vasa", Surname = "Jordo", AcademicTitle = "Teacher", ExperienceYear = 5, Patronymic = "Vasiliev" };
//var SubjectMath = new AcademicSubject() { SubjectName = "Mathematic", CountHouhrs = 150, NeedCompClass = false };
//Console.WriteLine(TeacherVasa.ToString());
//Console.WriteLine(SubjectMath.ToString());

//public class Teacher
//{

//    public string? Name { get; set; }
//    public string? Surname { get; set; }
//    public string? Patronymic { get; set; }
//    public int ExperienceYear { get; set; }
//    public string? AcademicTitle { get; set; }
//    public override string ToString()
//    {
//        return $"Имя:{Name}, фамилия:{Surname}, отчество:{Patronymic}, опыт работы:{ExperienceYear}, учебная должность:{AcademicTitle}";
//    }
//}

//public class AcademicSubject
//{
//    public string? SubjectName { get; set; }
//    public int CountHouhrs { get; set; }
//    public bool NeedCompClass { get; set; }
//    public override string ToString()
//    {
//        return $"Предмет который вы учите:{SubjectName}, количество часов отведенных на этот предмет:{CountHouhrs}, нужен ли компьютерный класс:{NeedCompClass}";
//    }
//}
#endregion
#region Laba 2
//var TeacherVasa = new Teacher() { Name = "Vasa", Surname = "Jordo", AcademicTitle = "Teacher", ExperienceYear = 5};
//var SubjectMath = new AcademicSubject() { SubjectName = "Mathematic", CountHouhrs = 150, NeedCompClass = false };
//Console.WriteLine(TeacherVasa.ToString());
//Console.WriteLine(SubjectMath.ToString());

//public class Teacher
//{
//    private string name = "Undefined";
//    public string Name { get { return name; } set { name = value; } }

//    private string surname = "Undefined";
//    public string Surname { get { return surname; } set { surname = value; } }

//    private string patronymic = "Undefined";
//    public string Patronymic { get { return patronymic; } set { patronymic = value; } }

//    private int experienceYear = 0;
//    public int ExperienceYear { get { return experienceYear; } set { experienceYear = value; } }

//    private string academicTitile = "Undefined";
//    public string AcademicTitle { get { return academicTitile; } set { academicTitile = value; } }
//    public override string ToString()
//    {
//        return $"Имя:{Name}, фамилия:{Surname}, отчество:{Patronymic}, опыт работы:{ExperienceYear}, учебная должность:{AcademicTitle}";
//    }
//}

//public class AcademicSubject
//{
//    private string subjectName = "Undefined";
//    public string SubjectName { get { return subjectName; } set { subjectName = value; } }

//    private int countHouhrs = 0;
//    public int CountHouhrs { get { return countHouhrs; } set { countHouhrs = value; } }

//    private bool needCompClass = false;
//    public bool NeedCompClass { get { return needCompClass; } set { needCompClass = value; } }
//    public override string ToString()
//    {
//        return $"Предмет который вы учите:{SubjectName}, количество часов отведенных на этот предмет:{CountHouhrs}, нужен ли компьютерный класс:{NeedCompClass}";
//    }
//}
#endregion
#region 3
//var teacherVasa = new Teacher();
//var teacherPeta = new Teacher("Peta");
//var teacherNiva = new Teacher("Niva", "Horward", "No", 5, "Teacher");
//var teacherNiva2 = new Teacher(teacherNiva);
//var subjectMath = new AcademicSubject();
//var subjectRus = new AcademicSubject(100);
//var subjectFith = new AcademicSubject("fith", 100, true);
//var subjectFith2 = new AcademicSubject(subjectFith);
//Console.WriteLine(teacherVasa.ToString());
//Console.WriteLine(teacherPeta.ToString());
//Console.WriteLine(teacherNiva.ToString());
//Console.WriteLine(teacherNiva2.ToString());
//Console.WriteLine(subjectMath.ToString());
//Console.WriteLine(subjectRus.ToString());
//Console.WriteLine(subjectFith.ToString());
//Console.WriteLine(subjectFith2.ToString());

//public class Teacher
//{

//    public string Name { get; private set; }
//    public string Surname { get; private set; }
//    public string Patronymic { get; private set; }
//    public int ExperienceYear { get; private set; }
//    public string AcademicTitle { get; private set; }
//    public Teacher()
//    {
//        Name = "Undefined";
//        Surname = "Undefined";
//        Patronymic = "Undefined";
//        ExperienceYear = 0;
//        AcademicTitle = "Undefined";
//    }
//    public Teacher(string name)
//    {
//        Name = name;
//        Surname = "Undefined";
//        Patronymic = "Undefined";
//        ExperienceYear = 0;
//        AcademicTitle = "Undefined";
//    }
//    public Teacher(string name, string surname, string patronymic, int experienceYear, string academicTitile)
//    {
//        Name = name;
//        Surname = surname;
//        Patronymic = patronymic;
//        ExperienceYear = experienceYear;
//        AcademicTitle = academicTitile;
//    }
//    public Teacher(Teacher teacher)
//    {
//        Name = teacher.Name;
//        Surname = teacher.Surname;
//        Patronymic = teacher.Patronymic;
//        ExperienceYear = teacher.ExperienceYear;
//        AcademicTitle = teacher.AcademicTitle;
//    }
//    public override string ToString()
//    {
//        return $"Имя:{Name}, фамилия:{Surname}, отчество:{Patronymic}, опыт работы:{ExperienceYear}, учебная должность:{AcademicTitle}";
//    }
//}

//public class AcademicSubject
//{
//    public string SubjectName { get; private set; }
//    public int CountHouhrs { get; private set; }
//    public bool NeedCompClass { get; private set; }
//    public AcademicSubject()
//    {
//        SubjectName = "Undefined";
//        CountHouhrs = 0;
//        NeedCompClass = false;
//    }
//    public AcademicSubject(int countHours)
//    {
//        SubjectName = "Undefined";
//        CountHouhrs = countHours;
//        NeedCompClass = false;
//    }
//    public AcademicSubject(string subjectName, int countHours, bool needCompClass)
//    {
//        SubjectName = subjectName;
//        CountHouhrs = countHours;
//        NeedCompClass = needCompClass;
//    }
//    public AcademicSubject(AcademicSubject academicSubject)
//    {
//        SubjectName = academicSubject.SubjectName;
//        CountHouhrs = academicSubject.CountHouhrs;
//        NeedCompClass = academicSubject.NeedCompClass;
//    }
//    public override string ToString()
//    {
//        return $"Предмет который вы учите:{SubjectName}, количество часов отведенных на этот предмет:{CountHouhrs}, нужен ли компьютерный класс:{NeedCompClass}";
//    }
//}
#endregion
#region Turple
//using Labs;

//var num = 123;
//var result = Method().Item1 == num;
//Console.WriteLine(result);
//foreach(var item in Method().Item5)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine(Method().Item4.Name + " " +Method().Item4.Age);

//static Tuple<int, double,string, Human, List<int>,List<string>> Method()
//{
//    return Tuple.Create(123, 12.2, "Text", new Human(){Name = "Nikita", Age = 17}, new List<int> { 1, 2, 5 }, new List<string> { "Nikita", "VOVA", "Nikolai" });
//}
#endregion
#region Lazy
//class Reader
//{
//    Lazy<Library> library = new Lazy<Library>();
//    public void ReadBook()
//    {
//        library.Value.GetBook();
//        Console.WriteLine("Читаем бумажную книгу");
//    }

//    public void ReadEbook()
//    {
//        Console.WriteLine("Читаем книгу на компьютере");
//    }
//}

//class Library
//{
//    private string[] books = new string[99];

//    public void GetBook()
//    {
//        Console.WriteLine("Выдаем книгу читателю");
//    }
//}
#endregion