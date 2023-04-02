interface IFilter
{
    string Filter(string textLine);
}
class LetterFilter : IFilter
{
    public string Filter(string textline)
    {
        string str = "";
        for (int i = 0; i < textline.Length; i++)
        {
            if (char.IsDigit(textline[i]))
            {
                str += textline[i];
            }
        }
        return str;
    }
}
class DigitFilter : IFilter
{
    public string Filter(string textline)
    {
        string str = "";
        char[] symbols = { ';', '-', '"', '(', ')', '.', '!', ' ', ',', ':',  '?' };
        for (int i = 0; i < textline.Length; i++)
        {
            if (char.IsLetter(textline[i]) || Array.IndexOf(symbols, textline[i]) >= 0)
            {
                str += textline[i];
            }
        }
        return str;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        DigitFilter stringLetters = new DigitFilter();
        Console.WriteLine(stringLetters.Filter("Кто очень03 любит учиться, у89 того о0чень хорошо будет получаться890347."));
        LetterFilter stringDigits = new LetterFilter();
        Console.WriteLine(stringDigits.Filter("Кто очень03 любит учиться, у89 того о0чень хорошо будет получаться890347"));
        Console.ReadKey(true);
    }
}