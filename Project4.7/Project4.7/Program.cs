using System;

namespace Project4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string С = "север", З = "запад", Ю = "юг", В = "восток";
            var N = new Random().Next(-1,2);
            Console.WriteLine(N);
            if (N == -1)
            {
                Console.WriteLine(В);
            }
            else if (N == 0)
            {
                Console.WriteLine(С);
            }
            else 
            {
                Console.WriteLine(З);
            }
        }
    }
}
