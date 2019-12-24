using System;

namespace Project2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //С дополнительной переменной
            Console.WriteLine("a=");
            byte a = byte.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            byte b = byte.Parse(Console.ReadLine());
            var i = a;
            a = b;
            b = i;
            Console.WriteLine(" a=" + a + "\n b=" + b);
        }
    }
}
