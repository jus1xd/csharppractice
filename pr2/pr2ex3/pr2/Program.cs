class CaesarCipher
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите текст для шифрования");
        string text = Console.ReadLine();
        Console.WriteLine("Введите ключ");
        int key = Convert.ToInt32(Console.ReadLine());
        string encodedText = Encode(text, key);
        Console.WriteLine("Зашифрованный текст: " + encodedText);
        Console.WriteLine("Расшифрованный текст: " + Decode(encodedText, key));
        Console.ReadLine();
    }

    static string Encode(string text, int key)
    {
        string encodedText = "";
        for (int i = 0; i < text.Length; i++)
        {
            encodedText += (char)(text[i] + key);
        }
        return encodedText;
    }

    static string Decode(string text, int key)
    {
        string decodedText = "";
        for (int i = 0; i < text.Length; i++)
        {
            decodedText += (char)(text[i] - key);
        }
        return decodedText;
    }
}
