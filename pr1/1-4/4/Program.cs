// See https://aka.ms/new-console-template for more information


Car audiRs6C6 = new Car();
audiRs6C6.carname = "Ауди RS6 в C6 кузове";
audiRs6C6.carspeed = 365;
Console.WriteLine($"         ");
audiRs6C6.Print();

Car vaz2115 = new Car();
vaz2115.carname = "Пятнарь (мой)";
vaz2115.carspeed = 375;
Console.WriteLine($"         ");
vaz2115.Print();

Car bmwE36 = new Car();
bmwE36.carname = "Взорванная бэха е36";
bmwE36.carspeed = 210;
Console.WriteLine($"         ");
bmwE36.Print();

Car mercW140 = new Car();
mercW140.carname = "Некрокабан";
mercW140.carspeed = 190;
Console.WriteLine($"         ");
mercW140.Print();

Console.WriteLine($"         ");
Console.WriteLine($"стритрейсеры в вк");
Console.WriteLine($"         ");

if (vaz2115.carspeed > audiRs6C6.carspeed)
{
    Console.WriteLine($"Пятнарь объехал аудюху");
}
if (audiRs6C6.carspeed> bmwE36.carspeed)
{
    Console.WriteLine($"Ауди RS6 в C6 кузове сделала бумер");
}
if (bmwE36.carspeed> mercW140.carspeed)
{
    Console.WriteLine($"Взорванная е36 пришла третьей, а некрокабан последним");
}

class Car
{
    public string carname;
    public int carspeed;
    public void Print()
    {
        Console.WriteLine($"Болид: {carname}");
        Console.WriteLine($"Максималка: {carspeed} км/ч");
        Console.WriteLine($"На спидаке нарисована максималка: {carspeed + 10} км/ч");
    }
}

