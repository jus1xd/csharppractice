using System;

static void Main()
{
    solveSqrtExpression solveSqrt = new solveSqrtExpression();

    void sqrtExpression(int a, int b, int c)
    {
        solveSqrt.setSqrt1(a, b, c);
        solveSqrt.setSqrt2(a, b, c);
    }

    sqrtExpression(1, 7, -1);

    Console.WriteLine("Корень 1" + solveSqrt.getSqrt1());
    Console.WriteLine("Корень 2" + solveSqrt.getSqrt2());
    Console.ReadKey();
}

class solveSqrtExpression
{
    private double sqrt1, sqrt2;

    public double getSqrt1()
    {
        return sqrt1;
    }

    public double getSqrt2()
    {
        return sqrt2;
    }

    public void setSqrt1(int a, int b, int c)
    { 
        double d = (b * b) - 4 * a * c;
        if (getSolving(a, b, c, d).Length > 0)
        {
            this.sqrt1 = getSolving(a, b, c, d)[0];
        }

        
    }

    public void setSqrt2(int a, int b, int c)
    {
        double d = (b * b) - 4 * a * c;

        if (getSolving(a, b, c, d).Length > 0)
        {
            this.sqrt2 = getSolving(a, b, c, d)[1];
        }
    }

    private double[] getSolving(int a, int b, int c, double d)
    {
        if (d > 0)
        {
            double sqrt1 = (-b + Math.Sqrt(d)) / (2 * a);
            double sqrt2 = (-b - Math.Sqrt(d)) / (2 * a);
            double[] sqrts = {sqrt1, sqrt2};
            return sqrts;
        }
        else if (d == 0)
        {
            double sqrt1 = (-b + Math.Sqrt(d)) / (2 * a);
            double[] sqrts = { sqrt1 };
            return sqrts;
        }
        else
        {
            double[] sqrts = { };
            return sqrts;
        }
    }
}

