using System;

namespace Task_04
{
    class Program
    { //Дано предложение. Определить, сколько в нем одинаковых пар соседних букв.​
        static void Main(string[] args)
        {
            string str= "обрезаем начиная с третьего символа";
            Console.WriteLine(str);
            int sum = 0;
            for (int i = 0; i < str.Length-1; i++)
            {
                for (int j = i+1; j < str.Length-1; j++)
                {
                    var answer = str[i].Equals(str[j]);
                    var answer2 = str[i+1].Equals(str[j+1]);
                    if (i != j & answer == true&answer2==true)
                    {
                        sum++;
                    }
                }
            }
            Console.WriteLine($"{sum}");
        }
    }
}
