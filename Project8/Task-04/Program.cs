using System;

namespace Task_04
{
    class Program
    { //Дан прямоугольный массив размером n x m. Поверните его на 90 градусов по часовой стрелке, записав результат в 
      //новый массив размером m x n.
        static void Main(string[] args)
        {
            int b = 10, a = 10,k,c;
            int[,] arr1 = new int[b, a];
            int[,] arr2 = new int[a,b];
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    arr1[i, j] = new Random().Next(100);
                    Console.Write(arr1[i, j] + "\t ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < b; i++)
            {
                k = a-1-i;
                c = 0-i;
                for (int j = 0; j < a; j++)
                {
                    arr2[i, j]= arr1[i+k,j-c];
                    Console.Write(arr2[i,j] + "\t ");
                    k--;
                    c+=1;
                }
                Console.WriteLine();
            }
        }
    }
}
