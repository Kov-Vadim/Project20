using System;

namespace Task_04
{
    
    class Class
    {
        int a = 10, b = 10;
        public int[,] arr1;
        public int[,] arr2;
        
        public Class(int a,int b)
        {
            this.arr1 = new int[a, b];
            this.arr2 = new int[a, b];
        }
        public void Values()
        {
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    arr1[i, j] = new Random().Next(100);
                    Console.Write(arr1[i, j] + "\t ");
                }
                Console.WriteLine();
            }
        }
        public void Change()
        {
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    arr2[i, j] = arr1[j, i];
                    Console.Write(arr2[i, j] + "\t ");
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    { //Класс будет содержать два метода: один заполнит массив значениями, второй произведет замену значений строк на 
      //значения столбцов.
        static void Main(string[] args)
        {
            Class class1 = new Class(10,10);
            class1.Values();
            Console.WriteLine();
            class1.Change();
        }
    }
}
