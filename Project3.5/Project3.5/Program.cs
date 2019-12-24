using System;

namespace Project3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name the amount of purchase:");
            double uah = double.Parse(Console.ReadLine());
            Console.WriteLine("Call a discount:");
            byte discount = byte.Parse(Console.ReadLine());
            Discound(discount, uah);
            Price(discount, uah);
        }

        static void Discound(double discount, double uah)
        {
            Console.WriteLine($"Discound={uah / 100 * discount}");
        }
        static void Price(double discount, double uah)
        {
            Console.WriteLine($"Purchase amount ={uah - uah / 100 * discount}");
        }
        
    }
}
