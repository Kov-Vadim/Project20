using System;

namespace Task_07
{
    class Program
    { //Дано предложение. Все его символы, стоящие на третьем, шестом, девятом и т. д. местах, заменить буквой а. ​
        static void Main(string[] args)
        {
            string str = "Обрезаем начиная с третьего символа.";
            Console.WriteLine(str);
            for (int i = 2; i < str.Length; i+=3)
            {
                str = str.Remove(i, 1);
                str = str.Insert(i,"a");
            }
            Console.WriteLine(str);
        }
    }
}
