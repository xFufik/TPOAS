using System;

namespace QA_Lab3_Fursov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Базовый класс Ellipse ");

            // g. статические объекты базового класса
            Ellipse e1 = new Ellipse(3, 2);
            Ellipse e2 = new Ellipse();

            Console.WriteLine("\nСтатический объект e1 (конструктор с параметрами):");
            e1.Display();
            Console.WriteLine($"\nПлощадь: {e1.Area()}");

            Console.WriteLine("\nВвод параметров для e2:");
            e2.Read();
            e2.Display();
            Console.WriteLine($"\nПлощадь: {e2.Area()}");

            // g. статические объекты производного класса
            Ellipse3D e3d1 = new Ellipse3D(4, 3, 2);
            Ellipse3D e3d2 = new Ellipse3D();

            Console.WriteLine("\nСтатический объект e3d1 (конструктор с параметрами):");
            e3d1.Display();
            Console.WriteLine($"\nПлощадь 3D: {e3d1.Area()}");

            Console.WriteLine("\nВвод параметров для e3d2:");
            Console.Write("Введите большую полуось a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите малую полуось b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите расстояние z: ");
            double z = Convert.ToDouble(Console.ReadLine());
            e3d2.Init(a, b, z);
            e3d2.Display();
            Console.WriteLine($"\nПлощадь 3D: {e3d2.Area()}");
        }
    }
}
