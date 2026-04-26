using System;

class Program
{
    static void Main(string[] args)
    {
        Ellipse e1 = new Ellipse();
        Ellipse e2 = new Ellipse();

        Console.WriteLine("Введите первый эллипс:");
        e1.Read();

        Console.WriteLine("\nВведите второй эллипс:");
        e2.Read();

        Console.WriteLine("\nПервый эллипс:");
        e1.Display();
        Console.WriteLine("Площадь: " + e1.Area());

        Console.WriteLine("\nВторой эллипс:");
        e2.Display();
        Console.WriteLine("Площадь: " + e2.Area());

        // add
        Ellipse e3 = Ellipse.add(e1, e2);
        Console.WriteLine("\nРезультат сложения эллипсов:");
        e3.Display();
        Console.WriteLine("Площадь: " + e3.Area());

        // демонстрация свойства B
        Console.WriteLine("\nПроверка свойства B");
        e1.B = 5;
        e1.Display();
    }
}