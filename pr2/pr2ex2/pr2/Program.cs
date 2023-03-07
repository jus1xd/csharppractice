nOperations n = new nOperations();
n.predictNumber();
while (true)
{
    int input = Convert.ToInt32(Console.ReadLine());
    if (n.setNumber(input))
    {
        n.predictNumber();
    }
    else
    {
        Console.WriteLine("Вы ошиблись");
        break;
    }
}


class nOperations {
    private int n = 0;

    public int getNumber () {
        return n;
    }

    public void resetNumber () {
        n = 0;
    }

    public bool setNumber (int n) {
        if (this.n+1 == n) {
            this.n = n;
            return true;
        } else {
            resetNumber();
            return false;
        }
    }

    public void predictNumber () {
        Console.WriteLine("Введите число " + (this.n+1));
    }
}

   
