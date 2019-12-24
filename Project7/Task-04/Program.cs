using System;

namespace Task_04
{
    class Program
    { //Сосчитайте количество различных чисел в массиве
        static void Main(string[] args)
        {
            
            int b = 10;
            int[] arr = new int[b];
            for (int i = 0; i < b; i++)
            {
                arr[i] = new Random().Next(10);
                Console.Write(arr[i] + " ");
            }
            int bCount = 0;
            int bRepetitive = 0;
            for (int i = 0; i < b; i++)
            {
                bCount = 0;
                for (int j = 0; j < b; j++)
                {
                    if (arr[i] == arr[j])
                        bCount++;
                }
                if (1 < bCount)
                    bRepetitive++;
            }
            Console.WriteLine();
            if (bRepetitive < 1)
            {
                Console.WriteLine("All elemnts in array is not same!\n");
            }
            else
            {
                Console.WriteLine( "Number of diferent elements is : " + (b- bRepetitive));
            }
            Console.WriteLine();
        }
    }
}
