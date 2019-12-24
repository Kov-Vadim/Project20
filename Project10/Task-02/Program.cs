using System;

namespace Task_02
{
    class Program
    { //Дано слово. Верно ли, что оно начинается и оканчивается на одну и ту же  букву?​
        static void Main(string[] args)
        {
            string[] str = { "hello","world", "oello" };
            string word = str[new Random().Next(0,3)] ;
            Console.WriteLine($"Word:{word}");
            Console.WriteLine(word[0].Equals(word[word.Length-1]));
        }
    }
}
