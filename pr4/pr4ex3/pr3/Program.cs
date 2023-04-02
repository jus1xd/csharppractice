class SLQCommand
{
    class Ork
    {
        private static int orkCounter;
        public static int allGold

        {
            get;
            private set;
        }

        public int amountGold
        {
            get;
            private set;
        }

        public Ork()
        {
            orkCounter++;
            allGold += 2;
            if (orkCounter > 5)
            {
                amountGold += 2;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ork orc1 = new Ork();
            Console.WriteLine(Ork.allGold);
            Ork orc2 = new Ork();
            Ork orc3 = new Ork();
            Console.WriteLine(Ork.allGold);
            Ork orc4 = new Ork();
            Ork orc5 = new Ork();
            Ork orc6 = new Ork();
            Console.WriteLine(orc6.amountGold);
            Console.ReadKey();
        }
    }

}