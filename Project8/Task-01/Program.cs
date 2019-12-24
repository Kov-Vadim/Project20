using System;

namespace Task_01
{
    class Program
    { //Найдите индексы первого вхождения максимального элемента. Выведите два числа: номер строки и номер столбца, 
      //в которых стоит наибольший элемент в двумерном массиве. Если таких элементов несколько, то выводится тот, у 
      //которого меньше номер строки, а если номера строк равны то тот, у которого меньше номер столбца.
        static void Main(string[] args)
        {
            int b = 10, a = 10;
            int[,] arr = new int[b, a];
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    arr[i, j] = new Random().Next(100);
                    Console.Write(arr[i, j] + "\t ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int max = arr[0, 0];
            string coords = string.Empty;
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                        coords = string.Format($"Coords max element:{i},{j}");
                    }
                }
            }
            Console.WriteLine(coords);
        }
    }
}
