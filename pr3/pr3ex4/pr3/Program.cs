class SLQCommand
{
    class IntList
    {
        private List<int> ListOfNumbers = new List<int>();

        public int Sum
        {
            get
            {
                return CalculateSum();
            }
        }
        public double Average
        {
            get
            {
                return CalculateAverage();
            }
        }
        public void AddNumber(int number)
        {
            ListOfNumbers.Add(number);
        }
        public void RemoveNumber(int number)
        {
            ListOfNumbers.Remove(number);
        }
        private int CalculateSum()
        {
            int sum = 0;
            foreach (int number in ListOfNumbers)
            {
                sum += number;
            }
            return sum;
        }
        private double CalculateAverage()
        {
            return Sum / (double)ListOfNumbers.Count;
        }
    }

    static void Main()
    {
        IntList letNumbers = new IntList();
        letNumbers.AddNumber(38);
        letNumbers.AddNumber(66);
        letNumbers.AddNumber(2);
        letNumbers.AddNumber(16);
        letNumbers.AddNumber(1);
        Console.WriteLine(letNumbers.Sum);
        Console.WriteLine(letNumbers.Average);
        Console.ReadKey();
    }
}


