using System;

public class Ellipse
{
    private double a; // большая полуось

    private double b; // малая полуось 

    public double B // property
    {
        get { return b; }
        set
        {
            if (value > 0 && value < a)
                b = value;
            else
            {
                Console.WriteLine("Некорректное значение b!");
                b = 1;
            }
        }
    }

    public void Init(double A, double B)
    {
        if (A > B && B > 0)
        {
            a = A;
            b = B;
        }
        else
        {
            Console.WriteLine("Некорректные значения (a > b > 0). Установлены значения по умолчанию.");
            a = 2;
            b = 1;
        }
    }
    public void Read()
    {
        Console.Write("Введите большую полуось a: ");
        double A = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите малую полуось b: ");
        double B = Convert.ToDouble(Console.ReadLine());

        Init(A, B);
    }

    public void Display()
    {
        Console.WriteLine($"Эллипс: a = {a}, b = {b}");
    }

    public double Area()
    {
        return Math.PI * a * b;
    }

    public static Ellipse add(Ellipse e1, Ellipse e2)
    {
        Ellipse res = new Ellipse();
        res.Init(e1.a + e2.a, e1.b + e2.b);
        return res;
    }
}
