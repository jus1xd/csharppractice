class TransportVehicle
{
    public string Name
    {
        get;
        set;
    }
    public int MaxSpeed
    {
        get;
        set;
    }
    public TransportVehicle(string name, int speed)
    {
        Name = name;
        MaxSpeed = speed;
    }
}
class Mixer : TransportVehicle
{
    public void MixConcrete()
    {
        Console.WriteLine("Мешает бетон");
    }
    public Mixer(string name, int speed) : base(name, speed)
    {
    }
}
class Machine : TransportVehicle
{
    public void TurnMusic()
    {
        Console.WriteLine("Громко включили плохую музыку");
    }
    public Machine(string name, int speed) : base(name, speed)
    {
    }
}

class Airplane : TransportVehicle
{
    public void OpilitPole()
    {
        Console.WriteLine("Поле опыленено");
    }
    public Airplane(string name, int speed) : base(name, speed)
    {
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        TransportVehicle Car = new TransportVehicle("ВАЗ-2115", 250);
        Machine Polytech = new Machine("Политех-машина", 50);
        Polytech.TurnMusic();
        Airplane Aircraft = new Airplane("СУ-27", 2756);
        Aircraft.OpilitPole();
        Mixer Beton = new Mixer("Бетономешалка-33", 100);
        Beton.MixConcrete();
        Console.ReadKey(true);
    }
}