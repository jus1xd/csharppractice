interface IChar
{
    void Draw(int size);
}
class VerticalLine : IChar
{
    public void Draw(int size)
    {
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("*");
        }
    }
}
class HorizontalLine : IChar
{
    public void Draw(int size)
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write("*");
        }
    }
}
class Square : IChar
{
    public void Draw(int size)
    {
        Console.WriteLine();
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

    }
}
internal class Program
{
    static void Main(string[] args)
    {
        List<IChar> chars = new List<IChar>();
        chars.Add(new VerticalLine());
        chars.Add(new HorizontalLine());
        chars.Add(new Square());
        foreach (IChar figure in chars)
        {
            figure.Draw(14);
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}