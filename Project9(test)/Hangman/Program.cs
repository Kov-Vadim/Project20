using System;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int k = 1; k != 0; k += 0)
            {
                string[] str = {"король","гараж","дерево","собака","солнце", "мама", "книга", "фрукт", "краб", "лодка", "земля", "дом", "вода", "дрова", "корабль", "барон", "газон", "газель", "здание" };
                int a = new Random().Next(0, 18);
                int b = str[a].Length*3/2;
                string word = str[a];
                string str2 = " ";
                string str1 = new string('_', str[a].Length);
                for (int i = 0; i != 10; i += 0)
                {

                    
                    if (b > 0& b!=0)
                    {
                        Console.WriteLine($"Ваше слово:{str1}");
                        Console.Write("Угадайте букву:");
                        string s1 = Console.ReadLine();
                        int v = 0;
                        for (int j = 0; j < word.Length; j++)
                        {
                            if (word[j] == s1[0])
                            {
                                if (v < 1)
                                {
                                    Console.WriteLine("Правильно!");
                                }
                                str1 = str1.Remove(j, 1);
                                str1 = str1.Insert(j, s1);
                                v++;
                                if (str1 == word)
                                {
                                    Console.WriteLine("Вы выграли АВТОМОБИЛЬ!!!");
                                    i = 10;
                                    k = 0;
                                }
                            }
                            else if (word[j] != s1[0] & j == word.Length - 1 & v == 0)
                            {
                                b--;
                                Console.WriteLine("Неправильно!");
                                str2 += s1 + " ";
                            }
                        }
                        Console.WriteLine("Неправильные варианты:" + str2);
                        Console.WriteLine($"{b} неправильных вариантов осталось");

                    }
                    else if(b<=0)
                    {
                        Console.WriteLine("Game over!!!");
                        Console.WriteLine($"Ваше слово:{word}");
                        Console.WriteLine("Может повезёт в следующий раз");
                        Console.WriteLine("Начать заново?(Да/Нет)");
                        for (int m = 1; m != 0; m += 0)
                        {
                            string s3 = Console.ReadLine();
                            if (s3 == "Да" | s3 == "да")
                            {
                                Console.Clear();
                                i = 10;
                                m = 0;
                            }
                            else if (s3 == "Нет" | s3 == "нет")
                            {
                                i = 10;
                                k = 0;
                                m = 0;
                            }
                            else
                            {
                                Console.WriteLine("Ошибка в ответе!\nПовторите попытку.");
                            }
                        }
                    }
                }
            }
        }
        
    }
}
