using System;

namespace Project2._4_Без_переменной
{
    class Program
    {
        static void Main(string[] args)
        {
            //Без дополнительной переменной
            int a = 5, b = 10;
            a = a + b;
            b = a - b;
            a = a - b;
       
            Console.WriteLine(" a=" + a + "\n b=" + b);
        }
    }
}
