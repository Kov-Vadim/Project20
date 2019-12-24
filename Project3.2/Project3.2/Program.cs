using System;

namespace Project3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter time in seconds:");
            double s = double.Parse(Console.ReadLine());
            double min = 60, h = min * 60, d = h * 24;

            Deys(d, s);
            Hours(h, s);
            Minutes(min, s);
        }

        static void Deys(double d, double s)
        {
            Console.WriteLine($"Deys={s / d}");
        }
        static void Hours(double h, double s)
        {
            Console.WriteLine($"Hours={s / h}");
        }
        static void Minutes(double min, double s)
        {
            Console.WriteLine($"Minutes={s / min}");
        }

    }
}
