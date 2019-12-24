using System;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age_year = 15;
            int age_Earth_s = age_year * 31557600;
            double age_Mercury = age_Earth_s * 0.2408467;
            double age_Venus = age_Earth_s * 0.61519726;
            double age_Mars = age_Earth_s * 1.8808158;
            double age_Jupiter = age_Earth_s * 11.862615;
            double age_Saturn = age_Earth_s * 29.447498;
            double age_Uranus = age_Earth_s * 84.016846;
            double age_Neptune = age_Earth_s * 164.79132;

            Console.WriteLine(age_Earth_s);
            Console.WriteLine(age_Mercury);
            Console.WriteLine(age_Venus);
            Console.WriteLine(age_Mars);
            Console.WriteLine(age_Jupiter);
            Console.WriteLine(age_Saturn);
            Console.WriteLine(age_Uranus);
            Console.WriteLine(age_Neptune);
        }
    }
}
