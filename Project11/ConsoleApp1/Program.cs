using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1;
            if(a==0 | b == 0)
            {
                Console.WriteLine(a);
            }
            if (a == 0 & b == 0)
            {
                Console.WriteLine(b);
            }

        }
    }
}
