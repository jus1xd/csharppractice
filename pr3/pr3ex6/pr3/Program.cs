
class RandomList
{
    private List<int> listOfNumbers = new List<int>();

    Random rand = new Random();

    private int n
    {
        set
        {
            SetLength(value);
        }
    }
    
    public double Deviation
    {
        get
        {
            return CalculateStandardDeviation();
        }
    }

    public double Median
    {
        get
        {
            return CalculateMedian();
        }
    }

    public double Average
    {
        get
        {
            return CalculateAverage();
        }
    }

    public double Variance
    {
        get
        {
            return CalculateVariance();
        }
    }

    private void SetLength(int n)
    {
        n = listOfNumbers.Count;
    }

    public void AddNumber()
    {
        listOfNumbers.Add(rand.Next(101));
    }

    public void RemoveNumber(int number)
    {
        listOfNumbers.Remove(number);
    }

    private double CalculateAverage()
    {
        int sum = 0;
        foreach (int number in listOfNumbers)
        {
            sum += number;
        }
        return sum / listOfNumbers.Count;
    }

    private double CalculateVariance()
    {
        double sum = 0;
        foreach (int number in listOfNumbers)
        {
            sum += Math.Pow((number - Average), 2);
        }
        return Math.Round(sum / listOfNumbers.Count, 2);
    }

    private double CalculateStandardDeviation()
    {
        CalculateVariance();
        return Math.Round(Math.Sqrt(Variance), 2);
    }

    private double CalculateMedian()
    {
        listOfNumbers.Sort();
        if (listOfNumbers.Count % 2 == 0)
        {
            return (listOfNumbers[listOfNumbers.Count / 2] + listOfNumbers[listOfNumbers.Count / 2 - 1]) / 2;
        }
        else
        {
            double middle = listOfNumbers.Count / 2;
            middle = Math.Ceiling(middle);
            return listOfNumbers[Convert.ToInt32(middle)];
        }
    }

    static void Main(string[] args)
    {
        RandomList letNumbers = new RandomList();
        for (int i = 0; i < 11; i++)
        {
            letNumbers.AddNumber();
        }
   
        Console.WriteLine(letNumbers.Median);
        Console.WriteLine(letNumbers.Variance);
        Console.WriteLine(letNumbers.Deviation);
        Console.ReadKey(true);
    }
}
