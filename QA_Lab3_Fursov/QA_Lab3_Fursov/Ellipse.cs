using System;

namespace QA_Lab3_Fursov
{
    /// <summary>
    /// Класс, представляющий эллипс.
    /// Содержит большую и малую полуоси, а также методы для вычисления площади.
    /// 
    /// Формула площади:
    /// \f[ S = \pi a b \f]
    /// 
    /// Иллюстрация эллипса:
    /// <img src="ellipse.png"/>
    /// 
    /// Граф наследования:
    /// \dot
    /// digraph G {
    ///   Ellipse -> Ellipse3D;
    /// }
    /// \enddot
    /// </summary>
    public class Ellipse
    {
        protected double a; // большая полуось
        protected double b; // малая полуось 

        /// <summary>
        /// Конструктор по умолчанию.
        /// Устанавливает значения a = 2, b = 1.
        /// </summary>
        public Ellipse()
        {
            a = 2;
            b = 1;
        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="A">Большая полуось</param>
        /// <param name="B">Малая полуось</param>
        public Ellipse(double A, double B)
        {
            Init(A, B);
        }

        /// <summary>
        /// Инициализация параметров эллипса.
        /// </summary>
        /// <param name="A">Большая полуось</param>
        /// <param name="B">Малая полуось</param>
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

        /// <summary>
        /// Получить значение большой полуоси.
        /// </summary>
        /// <returns>Значение a</returns>
        public double GetA() { return a; }

        /// <summary>
        /// Получить значение малой полуоси.
        /// </summary>
        /// <returns>Значение b</returns>
        public double GetB() { return b; }

        /// <summary>
        /// Ввод параметров эллипса с консоли.
        /// </summary>
        public void Read()
        {
            Console.Write("Введите большую полуось a: ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите малую полуось b: ");
            double B = Convert.ToDouble(Console.ReadLine());

            Init(A, B);
        }

        /// <summary>
        /// Вывод параметров эллипса.
        /// </summary>
        public virtual void Display()
        {
            Console.Write($"Эллипс: a = {a}, b = {b}");
        }

        /// <summary>
        /// Вычисляет площадь эллипса.
        /// 
        /// Формула:
        /// \f$ S = \pi a b \f$
        /// </summary>
        /// <returns>Площадь эллипса</returns>
        public virtual double Area()
        {
            return Math.PI * a * b;
        }

        /// <summary>
        /// Складывает два эллипса (суммирует полуоси).
        /// </summary>
        /// <param name="e1">Первый эллипс</param>
        /// <param name="e2">Второй эллипс</param>
        /// <returns>Новый эллипс</returns>
        public static Ellipse add(Ellipse e1, Ellipse e2)
        {
            Ellipse res = new Ellipse();
            res.Init(e1.a + e2.a, e1.b + e2.b);
            return res;
        }
    }

    /// <summary>
    /// Производный класс, представляющий трёхмерный эллипс.
    /// Добавляет третье измерение (z).
    /// 
    /// Формула:
    /// \f$ V = \pi a b z \f$
    /// </summary>
    public class Ellipse3D : Ellipse
    {
        private double z;

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Ellipse3D() : base()
        {
            z = 1;
        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="A">Большая полуось</param>
        /// <param name="B">Малая полуось</param>
        /// <param name="Z">Третье измерение</param>
        public Ellipse3D(double A, double B, double Z) : base(A, B)
        {
            Put(Z);
        }

        /// <summary>
        /// Получить значение Z.
        /// </summary>
        /// <returns>Значение z</returns>
        public double GetZ()
        {
            return z;
        }

        /// <summary>
        /// Установить значение Z.
        /// </summary>
        /// <param name="Z">Новое значение</param>
        public void Put(double Z)
        {
            z = Z;
        }

        /// <summary>
        /// Инициализация параметров 3D эллипса.
        /// </summary>
        public void Init(double A, double B, double Z)
        {
            base.Init(A, B);
            Put(Z);
        }

        /// <summary>
        /// Вывод параметров 3D эллипса.
        /// </summary>
        public override void Display()
        {
            base.Display();
            Console.Write($", z = {z}");
        }

        /// <summary>
        /// Вычисляет "объём".
        /// </summary>
        /// <returns>Значение объёма</returns>
        public override double Area()
        {
            return Math.PI * a * b * z;
        }

        /// <summary>
        /// Складывает два 3D эллипса.
        /// </summary>
        public static Ellipse3D add3D(Ellipse3D e1, Ellipse3D e2)
        {
            Ellipse3D result = new Ellipse3D();
            result.Init(e1.a + e2.a, e1.b + e2.b, e1.z + e2.z);
            return result;
        }
    }
}