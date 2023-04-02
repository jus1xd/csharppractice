class Package
{
    public int PWeight
    {
        get;
        private set;
    }

    public string PDescription
    {
        get;
        private set;
    }
    
    public Package(int weight, string description)
    {
        PWeight = weight;
        PDescription = description;
    }
}
class SendingService
{
    private static int LimitWeight;
    private const int Limit = 10;
    public void SendPackage(Package package)
    {
        LimitWeight += package.PWeight;
        if (LimitWeight >= Limit)
        {
            Console.WriteLine("Непредвиденная ошибка! Общий вес посылок превысил лимит, отправка прервана.");
        }
        else
        {
            Console.WriteLine("{0} весам {1} кг. успешно отправленл", package.PDescription, package.PWeight);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Package package_1 = new Package(4, "Стандартная посылка №0000001");
        Package package_2 = new Package(7, "Тяжеловесная посылка №0000002");
        SendingService sendingService = new SendingService();
        sendingService.SendPackage(package_1);
        sendingService.SendPackage(package_2);
        Console.ReadKey(true);
    }
}