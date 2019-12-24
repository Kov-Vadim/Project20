using System;

namespace Task_02
{
    class Worker
    {
        public string Surname;
        public string Position;
        public int YearOfReceipt;
        public Worker(string surname,string position,int yearOfReceipt)
        {
            Surname = surname;
            Position = position;
            YearOfReceipt = yearOfReceipt;
        }
    }
    class Program
    { //Определить класс с именем Worker, содержащий следующие поля:
      //- фамилия и инициалы работника;
      //- название занимаемой должности;
      //- год поступления на работу.
      //Методы:
      //- ввод данных в массив из n элементов в типа Worker;
      //- упорядочить по алфавиту фамилии работников;
      //- вывод работников, чей стаж работы в фирме превышает значение, введенное пользователем.
        static void Main(string[] args)
        {
            int a=0, b=0;
            int n = new Random().Next(20);
            Worker z = new Worker("","", 1);
            Worker[] workers = new Worker[5];
            workers[0] = (new Worker("Yorik","Developer", 2008));
            workers[1] = (new Worker("Vadim","Manager", 2004));
            workers[2] = (new Worker("Andrey","QA", 2012));
            workers[3] = (new Worker("Ravshan", "MinorWorker", 1996));
            workers[4] = (new Worker("Jamshud", "MinorWorker", 1996));

            for (int i=0; i < workers.Length; i++)
            {
                Console.WriteLine(workers[i].Surname);
            }
            Console.WriteLine();
            for(int i = 0; i < workers.Length; i++)
            {
                for(int j = 0; j < workers.Length; j++)
                {
                    if (workers[i].Surname[0] == 'A')
                    {
                        a = 1;
                    }
                    else if (workers[i].Surname[0] == 'B')
                    {
                        a = 2;
                    }
                    else if (workers[i].Surname[0] == 'C')
                    {
                        a = 3;
                    }
                    else if (workers[i].Surname[0] == 'D')
                    {
                        a = 4;
                    }
                    else if (workers[i].Surname[0] == 'E')
                    {
                        a = 5;
                    }
                    else if (workers[i].Surname[0] == 'F')
                    {
                        a = 6;
                    }
                    else if (workers[i].Surname[0] == 'G')
                    {
                        a = 7;
                    }
                    else if (workers[i].Surname[0] == 'H')
                    {
                        a = 8;
                    }
                    else if (workers[i].Surname[0] == 'I')
                    {
                        a = 9;
                    }
                    else if (workers[i].Surname[0] == 'J')
                    {
                        a = 10;
                    }
                    else if (workers[i].Surname[0] == 'K')
                    {
                        a = 11;
                    }
                    else if (workers[i].Surname[0] == 'L')
                    {
                        a = 12;
                    }
                    else if (workers[i].Surname[0] == 'M')
                    {
                        a = 13;
                    }
                    else if (workers[i].Surname[0] == 'N')
                    {
                        a = 14;
                    }
                    else if (workers[i].Surname[0] == 'O')
                    {
                        a = 15;
                    }
                    else if (workers[i].Surname[0] == 'P')
                    {
                        a = 16;
                    }
                    else if (workers[i].Surname[0] == 'Q')
                    {
                        a = 17;
                    }
                    else if (workers[i].Surname[0] == 'R')
                    {
                        a = 18;
                    }
                    else if (workers[i].Surname[0] == 'S')
                    {
                        a = 19;
                    }
                    else if (workers[i].Surname[0] == 'T')
                    {
                        a = 20;
                    }
                    else if (workers[i].Surname[0] == 'U')
                    {
                        a = 21;
                    }
                    else if (workers[i].Surname[0] == 'V')
                    {
                        a = 22;
                    }
                    else if (workers[i].Surname[0] == 'W')
                    {
                        a = 23;
                    }
                    else if (workers[i].Surname[0] == 'X')
                    {
                        a = 24;
                    }
                    else if (workers[i].Surname[0] == 'Y')
                    {
                        a = 25;
                    }
                    else if (workers[i].Surname[0] == 'Z')
                    {
                        a = 26;
                    }

                    if (workers[j].Surname[0] == 'A')
                    {
                        b = 1;
                    }
                    else if (workers[j].Surname[0] == 'B')
                    {
                        b = 2;
                    }
                    else if (workers[j].Surname[0] == 'C')
                    {
                        b = 3;
                    }
                    else if (workers[j].Surname[0] == 'D')
                    {
                        b = 4;
                    }
                    else if (workers[j].Surname[0] == 'E')
                    {
                        b = 5;
                    }
                    else if (workers[j].Surname[0] == 'F')
                    {
                        b = 6;
                    }
                    else if (workers[j].Surname[0] == 'G')
                    {
                        b = 7;
                    }
                    else if (workers[j].Surname[0] == 'H')
                    {
                        b = 8;
                    }
                    else if (workers[j].Surname[0] == 'I')
                    {
                        b = 9;
                    }
                    else if (workers[j].Surname[0] == 'J')
                    {
                        b = 10;
                    }
                    else if (workers[j].Surname[0] == 'K')
                    {
                        b = 11;
                    }
                    else if (workers[j].Surname[0] == 'L')
                    {
                        b = 12;
                    }
                    else if (workers[j].Surname[0] == 'M')
                    {
                        b = 13;
                    }
                    else if (workers[j].Surname[0] == 'N')
                    {
                        b = 14;
                    }
                    else if (workers[j].Surname[0] == 'O')
                    {
                        b = 15;
                    }
                    else if (workers[j].Surname[0] == 'P')
                    {
                        b = 16;
                    }
                    else if (workers[j].Surname[0] == 'Q')
                    {
                        b = 17;
                    }
                    else if (workers[j].Surname[0] == 'R')
                    {
                        b = 18;
                    }
                    else if (workers[j].Surname[0] == 'S')
                    {
                        b = 19;
                    }
                    else if (workers[j].Surname[0] == 'T')
                    {
                        b = 20;
                    }
                    else if (workers[j].Surname[0] == 'U')
                    {
                        b = 21;
                    }
                    else if (workers[j].Surname[0] == 'V')
                    {
                        b = 22;
                    }
                    else if (workers[j].Surname[0] == 'W')
                    {
                        b = 23;
                    }
                    else if (workers[j].Surname[0] == 'X')
                    {
                        b = 24;
                    }
                    else if (workers[j].Surname[0] == 'Y')
                    {
                        b = 25;
                    }
                    else if (workers[j].Surname[0] == 'Z')
                    {
                        b = 26;
                    }
                    if (a < b)
                    {
                        z = workers[i];
                        workers[i] = workers[j];
                        workers[j] = z;
                    }
                }

            }
            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine(workers[i].Surname);
            }
            Console.WriteLine();
            Console.WriteLine($"Enter employee position\n1:MinorWorker\n2:QA\n3:Developer\n4:Manager");
            b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].Position == "Manager")
                {
                    a = 4;
                }
                else if (workers[i].Position == "Developer")
                {
                    a = 3;
                }
                else if (workers[i].Position == "QA")
                {
                    a = 2;
                }
                else if (workers[i].Position == "MinorWorker")
                {
                    a = 1;
                }
                if (a > b)
                {
                    Console.WriteLine(workers[i].Position);
                }
            }
        }
    }
}
