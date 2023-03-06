
solveSqrtExpression solveSqrt = new solveSqrtExpression();
void sqrtExpression(int a, int b, int c)
{
    solveSqrt.setDiscr(a, b, c);
    solveSqrt.setSqrt1(a, b, c);
    solveSqrt.setSqrt2(a, b, c);
}

//sqrtExpression(9, -6, 2); // нет корней
 sqrtExpression(-1, 7, 8); // -1, 8
//sqrtExpression(2, 5, -7); // 

Console.WriteLine("Дискриминант  " + solveSqrt.getDiscr());
if (solveSqrt.getSqrt1() == -999999999 && solveSqrt.getSqrt2() == -999999999)
{
    Console.WriteLine("Корней нет");
}
else if (solveSqrt.getSqrt1() == -999999999 || solveSqrt.getSqrt2() == -999999999)
{
    if (solveSqrt.getSqrt1() == -999999999)
    {
        Console.WriteLine("Корень 1: Корня нет");
    } else
    {
        Console.WriteLine("Корень 2: Корня нет");
    }
} else
{
    Console.WriteLine("Корень 1  " + solveSqrt.getSqrt1());
    Console.WriteLine("Корень 2  " + solveSqrt.getSqrt2());
}

Console.ReadKey();

class solveSqrtExpression
{
    private double sqrt1, sqrt2, discr;
    
    public double getSqrt1()
    {
        return sqrt1;
    }
    public double getSqrt2()
    {
        return sqrt2;
    }
    public double getDiscr()
    {
        return discr;
    }
    public void setSqrt1(int a, int b, int c)
    {
        this.sqrt1 = CalculateRoots(a, b, getDiscr())[0];
    }
    public void setSqrt2(int a, int b, int c)
    {
        this.sqrt2 = CalculateRoots(a, b, getDiscr())[1];
    }
    public void setDiscr(int a, int b, int c)
    {
        this.discr = (b * b) - 4 * a * c;
    }
    private double[] CalculateRoots(int a, int b, double d)
    {
        if (d > 0)
        {
            double sqrt1 = (-b + Math.Sqrt(d)) / (2 * a);
            double sqrt2 = (-b - Math.Sqrt(d)) / (2 * a);
            double[] sqrts = { sqrt1, sqrt2 };
            return sqrts;
        }
        else if (d == 0)
        {
            double sqrt1 = (-b + Math.Sqrt(d)) / (2 * a);
            double[] sqrts = { sqrt1, -999999999 };
            return sqrts;
        }
        else
        {
            double[] sqrts = {-999999999, -999999999 };
            return sqrts;
        }
    }
}
