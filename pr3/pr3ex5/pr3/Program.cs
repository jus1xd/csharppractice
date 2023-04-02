class SLQCommand
{
    class SmsMessage
    {
        private double _initialprice;
        private double _symbolprice;
        private string _messagetext;
        private int _maxlength;
        
       
        public double InitialPrice
        {
            get
            {
                return _initialprice;
            }
            private set
            {
                _initialprice = value;
            }
        }
        public double SymbolPrice
        {
            get
            {
                return _symbolprice;
            }
            private set
            {
                _symbolprice = value;
            }
        }

        public string MessageText
        {
            get
            {
                return _messagetext;
            }
            private set
            {
                _messagetext = NormalizeMessageText(value, _maxlength);
            }
        }

        public int MaxLength
        {
            get
            {
                return _maxlength;
            }
            private set
            {
                _maxlength = value;
            }
        }

        private double Price
        {
            get
            {
                return CalculatePrice(_initialprice, _symbolprice);
            }
        }

        public SmsMessage(string text, int length, double initialprice, double symbolprice)
        {
            MessageText = text;
            MaxLength = length;
            InitialPrice = initialprice;
            SymbolPrice = symbolprice;
        }

        public void SendMessage()
        {
            Console.WriteLine($"Отправлено сообщение '{_messagetext}' длиной {_messagetext.Length} символов и стоимостью {Price} руб.");
        }

        private string NormalizeMessageText(string text, int length)
        {
            if (text.Length > length)
            {
                return text.Substring(0, text.Length - length);
            }
            return text;
        }

        private double CalculatePrice(double initialprice, double symbolprice)
        {
            if (_messagetext.Length < 65)
            {
                return initialprice;
            }
            else
            {
                int length = MessageText.Length - 65;
                return initialprice + length * symbolprice;
            }
        }
    }
    static void Main(string[] args)
    {
        SmsMessage startSms = new SmsMessage("Здравствуйте, я менеджер по найму в Lamoda, и в настоящее время мы нанимаем 99 онлайн-сотрудников на неполный рабочий день.", 50, 3, 0.9);
        startSms.SendMessage();
        Console.ReadKey();
    }
}


