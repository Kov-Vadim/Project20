using System;

namespace Task_05
{
    class Program
    { //Дан текст. Определить, сколько в нем предложений. ​
        static void Main(string[] args)
        {
            string str = "Обрезаем начиная с третьего символа.";
            Console.WriteLine(str);
            int sum = 0;
            for (int i = 1; i < str.Length ; i++)
            {
                if (str[i] != str[i-1] &(str[i]=='.'| str[i] =='!'| str[i] =='?'))
                {
                    sum++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
