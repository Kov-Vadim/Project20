using System;

namespace Task_1
{
    class Program
    { //Заполнить массив из десяти элементов значениями, вводимыми с клавиатуры в ходе выполнения программы.
        static void Main(string[] args)
        {
            int b = 10;
            int[] a = new int[b];
            for (int i = 0; i < b; i++)
            {
                a[i] = Convert.ToByte(Console.ReadLine());

                
            }
        }
    }
}
