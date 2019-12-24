using System;

namespace Task_03
{ 
    class Program
    { //Даны два слова. Верно ли, что первое слово начинается на ту же букву, на которую заканчивается второе слово? ​
        static void Main(string[] args)
        {
            string[] str = { "hello", "oar" };
            string word = str[new Random().Next(0, 2)];
            string word2 = str[new Random().Next(0, 2)];
            Console.WriteLine($"Word1:{word}\nWord2:{word2}");
            Console.WriteLine(word[0].Equals(word2[word2.Length - 1]));
        }
    }
}
