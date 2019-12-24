using System;

namespace Task_08
{
    class Program
    { //Дано слово. Поменять местами его вторую и пятую буквы. ​
        static void Main(string[] args)
        {
            string str = "Hello";
            Console.WriteLine(str);
            string str2 = string.Empty, str3 = string.Empty;
            str2 += str[1];
            str3 += str[4];
            str = str.Remove(1, 1);
            str = str.Insert(1, str3);
            str = str.Remove(4, 1);
            str = str.Insert(4, str2);
            Console.WriteLine(str);
        }
    }
}
