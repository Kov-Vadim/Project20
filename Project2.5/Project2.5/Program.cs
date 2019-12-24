using System;

namespace Project2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance:");
            byte distance_centimeters = byte.Parse(Console.ReadLine());
            double distance_meters = distance_centimeters * 0.01;
            Console.WriteLine(distance_meters);
        }
    }
}
