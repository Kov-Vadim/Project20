using System;

namespace Task_3
{
    class Program
    { //Найти: а) все двузначные числа, сумма квадратов цифр которых делится на 13; б) все двузначные числа, обладающие
      //следующим свойством: если к сумме цифр числа прибавить квадрат этой суммы, то получится снова искомое число.
        static void Main(string[] args)
        {
            for (int a = 10; a < 100; a++)
            {
                if (((a*a)+(a*a))%13 == 0)
                {
                  Console.WriteLine($"a={a}"); 
                }
                
            }
            int sum,i,j;
            for (int b = 10; b < 100; b++)
            {
                i = b / 10;
                j = b % 10;
                sum = i + j;
                if (sum + (sum * sum) == b)
                {
                    Console.WriteLine($"b={b}");
                }

            }

        }
    }
}
