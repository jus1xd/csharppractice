class Human
{
   
    public int Age
    {
        get;
        set;
    }
    public char Gender
    {
        get;
        set;
    }
    public string Fullname
    {
        get;
        set;
    }
    public Human(string fullname, int age, char gender)
    {
        Fullname = fullname;
        Age = age;
        Gender = gender;
    }
}
class StuffUnit : Human
{
    public string Position
    {
        get;
        set;
    }
    public StuffUnit(string fullname, int age, char gender, string position) : base(fullname, age, gender)
    {

        Position = position;
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Human Zayciv = new Human("Зайцив Владислав", 18, 'М');
        Console.WriteLine(Zayciv.Fullname);
        StuffUnit Marchenka = new StuffUnit("Марченка Андрей", 18, 'М', "Дизайнер");
        Console.WriteLine(Marchenka.Position);
        Console.ReadKey();
    }
}