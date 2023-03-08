class SmsMessage
{
    private string MessageText { get; set; }
    private double Price { get; set; }


    public SmsMessage(string messageText)
    {
        MessageText = messageText;
        Price = 0;
    }

    public void CalculatePrice()
    {
        if (MessageText.Length <= 65)
        {
            Price = 150;
        }
        else
        {
            Price = (150 + (MessageText.Length - 65) * 50) / 100;
        }
    }

    public override string ToString()
    {
        return $"Сообщение: {MessageText}, Цена: {Price}";
    }

    public static void Main(string[] args)
    {
        SmsMessage message = new SmsMessage("Я пишу тебе письмо из сорок пятого года и очень люблю тебя моя малышка и дрянь!");
        message.CalculatePrice();
        Console.WriteLine(message);
    }
}