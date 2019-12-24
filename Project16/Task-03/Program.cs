using System;

namespace Task_03
{
    class Sorting
    {
        public int A { get; set; }
        public double[] array;
        public Sorting(int a)
        {
            A = a;
            array = new double[A];
        }
        public void Array()
        {
            for(int i = 0; i < A; i++)
            {
                array[i] = new Random().Next(100);
                Console.Write($"{array[i]}\t");
            }
            Console.WriteLine();
        }
        public void Sort()
        {
            double z;
            for (int i = 0; i < A; i++)
            {
                for (int j = i; j < A; j++)
                {
                    if (array[i] > array[j])
                    {
                        z = array[i];
                        array[i] = array[j];
                        array[j] = z;
                    }
                }
            }
        }
        public void NewArray()
        {
            for (int i = 0; i < A; i++)
            {
                Console.Write($"{array[i]}\t");
            }
            Console.WriteLine();
        }
    }
    class Program
    { //Создать расширяющий метод для целочисленного массива, который сортирует элементы массива по возрастанию.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of numbers in the array");
            int b = Convert.ToInt32(Console.ReadLine());
            Sorting sorting = new Sorting(b);
            sorting.Array();
            sorting.Sort();
            sorting.NewArray();
        }
    }
}
