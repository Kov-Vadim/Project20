using System;

namespace Task_01
{
    class Program
    { //Вывести на экран все элементы второй строки массива

        static void Main(string[] args)
        {
            int a=10,b=10;

            int[,] c = new int[a,b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    c[i, j] = new Random().Next(100);
                    Console.Write(c[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    
                    Console.Write(c[1, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
