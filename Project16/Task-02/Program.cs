using System;

namespace Task_02
{
    class Class
    {

    }
    static class FindAndReplaceManager
    {
        public static string Str = "С идеей инкапсуляции программной логики тесно связана идея защиты данных. В идеале данные состояния объекта " +
        "должны быть специфицированы с использованием ключевого слова private (или, возможно, protected). Таким образом, внешний мир должен " +
        "вежливо попросить, если захочет изменить или получить лежащее в основе значение. Это хороший принцип, поскольку общедоступные элементы " +
        "данных можно легко повредить (даже нечаянно, а не преднамеренно).";
        public static void FindNext(this Class class1,string str)
        {
            int a = 0,z=0;
            int[] b = new int[str.Length];
            for(int i=0; i < str.Length; i++)
            {
                b[i] = 0;
            }
            for (int i = 0; i < str.Length; i=i+a)
            {

                for(int j =b[i-a]+a; j < Str.Length; j++)
                {
                    a = 1;
                    if (str[i] == Str[j])
                    {
                        b[i] = j;
                        z++;
                        j = Str.Length;
                        break;
                    }
                    else if (z >= 1 & str[i] != Str[j]&z<str.Length)
                    {
                        z = 0;
                        a = 0;
                        for (int k = 0; k < str.Length; k++)
                        {
                            b[k] = j;
                        }
                        i = 0;

                    }


                }
            }
            a = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (i!=str.Length-1&b[i]==b[i+1]-1)
                {

                    for (int j = 0; j < str.Length; j++)
                    {
                        Console.Write($"{b[j]}\t");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Error!\nNo character sequence found");
                    break;
                }
            }

        }
    }
    class Program
    { //Создать статический класс FindAndReplaceManager с методом void FindNext(string str) для поиска по книге. При вызове этого метода, 
      //производится последовательный поиск строки в книге.(Книга любая, подгружаем с помощью Filestream)
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the required you text");
            string str = Console.ReadLine();
            Class class1 = new Class();
            class1.FindNext(str);

        }
    }
}
