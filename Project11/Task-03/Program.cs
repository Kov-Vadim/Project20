using System;

namespace Task_03
{
    class Price
    {
        public string ProduktName;
        public string NameOfShop;
        public double Cost;
        public Price(string produktName,string nameOfShop,double cost)
        {
            ProduktName = produktName;
            NameOfShop = nameOfShop;
            Cost = cost;
        }
    }
    class Program
    { //Определить класс с именем Price, содержащий следующие поля:
      //- название товара;
      //- название магазина, в котором продается товар;
      //- стоимость товара в грн.
      //Методы:
      //- ввод данных в массив из n элементов в типа Price;
      //- упорядочить в алфавитном порядке по названиям товаров;
      //- вывод информации о товаре, название которого ввел пользователь.
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            Price z = new Price("","",1);
            Price[] prices = new Price[5];
            prices[0] = (new Price("stikers", "Antoshka", 169));
            prices[1] = (new Price("phone", "Citrus", 5000));
            prices[2] = (new Price("bread", "ATB", 10));
            prices[3] = (new Price("shampoo", "Eva", 30));
            prices[4] = (new Price("comb", "Avrora", 15));
            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine(prices[i].ProduktName);
            }
            Console.WriteLine();
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = 0; j < prices.Length; j++)
                {
                    if (prices[i].ProduktName[0] == 'a')
                    {
                        a = 1;
                    }
                    else if (prices[i].ProduktName[0] == 'b')
                    {
                        a = 2;
                    }
                    else if (prices[i].ProduktName[0] == 'c')
                    {
                        a = 3;
                    }
                    else if (prices[i].ProduktName[0] == 'd')
                    {
                        a = 4;
                    }
                    else if (prices[i].ProduktName[0] == 'e')
                    {
                        a = 5;
                    }
                    else if (prices[i].ProduktName[0] == 'f')
                    {
                        a = 6;
                    }
                    else if (prices[i].ProduktName[0] == 'g')
                    {
                        a = 7;
                    }
                    else if (prices[i].ProduktName[0] == 'h')
                    {
                        a = 8;
                    }
                    else if (prices[i].ProduktName[0] == 'i')
                    {
                        a = 9;
                    }
                    else if (prices[i].ProduktName[0] == 'j')
                    {
                        a = 10;
                    }
                    else if (prices[i].ProduktName[0] == 'k')
                    {
                        a = 11;
                    }
                    else if (prices[i].ProduktName[0] == 'l')
                    {
                        a = 12;
                    }
                    else if (prices[i].ProduktName[0] == 'm')
                    {
                        a = 13;
                    }
                    else if (prices[i].ProduktName[0] == 'n')
                    {
                        a = 14;
                    }
                    else if (prices[i].ProduktName[0] == 'o')
                    {
                        a = 15;
                    }
                    else if (prices[i].ProduktName[0] == 'p')
                    {
                        a = 16;
                    }
                    else if (prices[i].ProduktName[0] == 'q')
                    {
                        a = 17;
                    }
                    else if (prices[i].ProduktName[0] == 'r')
                    {
                        a = 18;
                    }
                    else if (prices[i].ProduktName[0] == 's')
                    {
                        a = 19;
                    }
                    else if (prices[i].ProduktName[0] == 't')
                    {
                        a = 20;
                    }
                    else if (prices[i].ProduktName[0] == 'u')
                    {
                        a = 21;
                    }
                    else if (prices[i].ProduktName[0] == 'v')
                    {
                        a = 22;
                    }
                    else if (prices[i].ProduktName[0] == 'w')
                    {
                        a = 23;
                    }
                    else if (prices[i].ProduktName[0] == 'x')
                    {
                        a = 24;
                    }
                    else if (prices[i].ProduktName[0] == 'y')
                    {
                        a = 25;
                    }
                    else if (prices[i].ProduktName[0] == 'z')
                    {
                        a = 26;
                    }

                    if (prices[j].ProduktName[0] == 'a')
                    {
                        b = 1;
                    }
                    else if (prices[j].ProduktName[0] == 'b')
                    {
                        b = 2;
                    }
                    else if (prices[j].ProduktName[0] == 'c')
                    {
                        b = 3;
                    }
                    else if (prices[j].ProduktName[0] == 'd')
                    {
                        b = 4;
                    }
                    else if (prices[j].ProduktName[0] == 'e')
                    {
                        b = 5;
                    }
                    else if (prices[j].ProduktName[0] == 'f')
                    {
                        b = 6;
                    }
                    else if (prices[j].ProduktName[0] == 'g')
                    {
                        b = 7;
                    }
                    else if (prices[j].ProduktName[0] == 'h')
                    {
                        b = 8;
                    }
                    else if (prices[j].ProduktName[0] == 'i')
                    {
                        b = 9;
                    }
                    else if (prices[j].ProduktName[0] == 'j')
                    {
                        b = 10;
                    }
                    else if (prices[j].ProduktName[0] == 'k')
                    {
                        b = 11;
                    }
                    else if (prices[j].ProduktName[0] == 'l')
                    {
                        b = 12;
                    }
                    else if (prices[j].ProduktName[0] == 'm')
                    {
                        b = 13;
                    }
                    else if (prices[j].ProduktName[0] == 'n')
                    {
                        b = 14;
                    }
                    else if (prices[j].ProduktName[0] == 'o')
                    {
                        b = 15;
                    }
                    else if (prices[j].ProduktName[0] == 'p')
                    {
                        b = 16;
                    }
                    else if (prices[j].ProduktName[0] == 'q')
                    {
                        b = 17;
                    }
                    else if (prices[j].ProduktName[0] == 'r')
                    {
                        b = 18;
                    }
                    else if (prices[j].ProduktName[0] == 's')
                    {
                        b = 19;
                    }
                    else if (prices[j].ProduktName[0] == 't')
                    {
                        b = 20;
                    }
                    else if (prices[j].ProduktName[0] == 'u')
                    {
                        b = 21;
                    }
                    else if (prices[j].ProduktName[0] == 'v')
                    {
                        b = 22;
                    }
                    else if (prices[j].ProduktName[0] == 'w')
                    {
                        b = 23;
                    }
                    else if (prices[j].ProduktName[0] == 'x')
                    {
                        b = 24;
                    }
                    else if (prices[j].ProduktName[0] == 'y')
                    {
                        b = 25;
                    }
                    else if (prices[j].ProduktName[0] == 'z')
                    {
                        b = 26;
                    }
                    if (a < b)
                    {
                        z = prices[i];
                        prices[i] = prices[j];
                        prices[j] = z;
                    }
                }

            }
            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine(prices[i].ProduktName);
            }
            Console.WriteLine();
            
            Console.WriteLine();
            for (int i = 0; i < 1; i++)
            {
                a = 0;
                Console.Write("Enter product name:");
                string str = Console.ReadLine();
                Console.WriteLine();
                for (int j = 0; j < prices.Length; j++)
                {
                    if (prices[j].ProduktName == str)
                    {
                        Console.WriteLine($"NameOfShop:{prices[i].NameOfShop}\nCost:{prices[i].Cost}");
                        a++;
                    }
                    else if (i == prices.Length-1 & prices[j].ProduktName != str & a>0)
                    {
                        Console.WriteLine("Error!\nSuch product is not listed.Try again");
                    }

                }
            }

        }
    }
}
