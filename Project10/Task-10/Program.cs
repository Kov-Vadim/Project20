using System;

namespace Task_10
{
    class Program
    { //Дано натуральное число n (n  1000). Напечатать это число русскими словами (тринадцать, сто пять, двести сорок 
      //один, тысяча и т. д.).
        static void Main(string[] args)
        {
            int n = 111;// new Random().Next(1001);
            Console.WriteLine(" "+n);
            if (n == 1000)
            {
                Console.WriteLine("тысяча");
            }
            if (n != 1000)
            {
                string[] c = {" ","сто ","двести ","триста ","четыреста ","пятьсот ","шестьсот ","семьсот ","восемьсот ",
                    "девятьсот " };
                if ((n <= 10 | n >= 20)&n<=99 | n >= 100 & (n % 100 <= 10 | n % 100 >= 20))
                {
                    string[] a = {" ","один ","два ","три ","четыре ","пять ","шесть ","семь ","восемь ","девять "};
                    string[] b = {" ","десять ","двадцать ","тридцать ","сорок ","пятьдесят ","шестьдесят ","семьдесят ",
                    "восемьдесят ","девяносто "};
                    string str = " ";
                    if (n >= 100)
                    {
                        str += c[n / 100];
                        str += b[n % 100 /10];
                        str += a[n%10];
                        str = str.Replace("  ", " ");

                        Console.WriteLine(str);
                    }
                    else if (n <= 99)
                    {
                        str += b[n % 10];
                        str += a[n / 10];
                        str = str.Replace("  ", " ");
                        Console.WriteLine(str);
                    }
                }
                else if(n >= 11 & n <= 19 | n >= 100 & n % 100 >= 11 & n % 100 <= 19)
                {
                    string[] a = {" ","одинадцать ","двенадцать ","тринадцать ","четырнадцать ","пятнадцать ",
                    "шестнадцать ","семнадцать ","восемьнадцать ","девятнадцать "};
                    string str = " ";
                    if (n >= 100)
                    {
                        str += c[n / 100];
                        str += a[n % 10];
                        str = str.Replace("  ", " ");
                        Console.WriteLine(str);
                    }
                    else if (n <= 99)
                    {
                        str += a[n-10];
                        str = str.Replace("  ", " ");
                        Console.WriteLine(str);
                    }
                }
                
            }
        }
    }
}
