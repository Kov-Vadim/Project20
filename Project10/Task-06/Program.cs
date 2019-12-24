using System;

namespace Task_06
{
    class Program
    { //Дано предложение, в котором имеются одна буква с и одна буква Т. Определить, какая из них встречается раньше 
      //(при просмотре слова слева направо)​
        static void Main(string[] args)
        {
            string str = "Обрезаем начиная с третьего символа.";
            Console.WriteLine(str);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] =='с')
                {
                    Console.WriteLine("с");
                    break;
                }
                else if (str[i] == 'т')
                {
                    Console.WriteLine("т");
                    break;
                }
            }
        }
    }
}
