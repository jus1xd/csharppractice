class Phone
{
    public Phone(string model, string number)
    {
        Model = model;
        Number = number;
    }
    public string Model
    {
        get;
        set;
    }
    public string Number
    {
        get;
        set;
    }
    public void Call(string number)
    {
        Console.WriteLine($"Вызов по номеру {number}");
        WriteToLog($"Вызов {number}");
    }
    protected void WriteToLog(string text)
    {
        File.AppendAllText("log.txt", $"{Model}, {DateTime.Now}: {text}\n");
    }
}
class Smartphone : Phone
{
    public Smartphone(string model, string number, double cameraResolution) : base(model, number)
    {
        CameraResolution = cameraResolution;
    }
    public double CameraResolution
    {
        get;
        set;
    }
    public void Shoot()
    {
        Console.WriteLine("Сделан снимок");
        WriteToLog($"Сделан снимок");
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Phone myHomePhone = new Phone("Windows Phone", "+79205550517");
        myHomePhone.Call("+79354676437");
        Smartphone myWorkPhone = new Smartphone("iPhone 11", "+79517615017", 12);
        myWorkPhone.Call("911");
        myWorkPhone.Shoot();
        Console.ReadKey();
    }
}