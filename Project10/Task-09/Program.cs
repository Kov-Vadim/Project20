using System;

namespace Task_09
{
    class Program
    { //Дан текст. Найти сумму всех имеющихся в нем чисел.​
        static void Main(string[] args)
        {
            string text = "4f855g73f";
            Console.WriteLine(text);
            int sum=0;
            for(int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]))
                {
                    sum += int.Parse(text[i].ToString());
                }
            }
            Console.WriteLine($"Sum={sum}");
        }
    }
}
