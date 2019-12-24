using System;

namespace Task_1
{
    class Program
    {  //Найти сумму положительных нечетных чисел, меньших 50
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i=0;i<50;i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
                
            }
            Console.WriteLine($"sum={sum}");
        }
    }
}
