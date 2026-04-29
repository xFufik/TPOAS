using System;

namespace QA_Lab3_Fursov
{
    public class Ellipse
    {
        protected double a; // большая полуось
        protected double b; // малая полуось 

        public Ellipse()
        {
            a = 2;
            b = 1;
        }

        public Ellipse(double A, double B)
        {
            Init(A, B);
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

        // геттеры для доступа к полям
        public double GetA() { return a; }
        public double GetB() { return b; }

        public void Read()
        {
            Console.Write("Введите большую полуось a: ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите малую полуось b: ");
            double B = Convert.ToDouble(Console.ReadLine());

            Init(A, B);
        }

        public virtual void Display()
        {
            Console.Write($"Эллипс: a = {a}, b = {b}");
        }

        public virtual double Area()
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

    // Производный класс
    public class Ellipse3D : Ellipse
    {
        private double z;

        public Ellipse3D() : base()  // вызов конструктора базового класса
        {
            z = 1;
        }

        public Ellipse3D(double A, double B, double Z) : base(A, B)  // вызов базового конструктора
        {
            Put(Z);
        }

        // методы Get и Put для работы с полем z
        public double GetZ()
        {
            return z;
        }

        public void Put(double Z)
        {
            z = Z;
        }

        // перегрузка Init 
        public void Init(double A, double B, double Z)
        {
            base.Init(A, B);
            Put(Z);
        }

        // перегрузка Display
        public override void Display()
        {
            base.Display();
            Console.Write($", z = {z}");
        }

        // перегрузка метода Area
        public override double Area()
        {
            return Math.PI * a * b * z;
        }

        public static Ellipse3D add3D(Ellipse3D e1, Ellipse3D e2)
        {
            Ellipse3D result = new Ellipse3D();
            result.Init(e1.a + e2.a, e1.b + e2.b, e1.z + e2.z);
            return result;
        }
    }
}
