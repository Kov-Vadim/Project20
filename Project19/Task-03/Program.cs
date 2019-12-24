using System;

namespace Task_03
{
    abstract class Workers
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public int YearOfReceipt { get; set; }
        public double Wage { get; set; }
        
    }
    class Program
    { //Построить три класса (базовый и 2 потомка), описывающих некоторых работников с почасовой оплатой (один из 
      //потомков) и фиксированной оплатой (второй потомок).

        //а) Описать в базовом классе абстрактный метод для расчета среднемесячной заработной платы.Для «повременщиков» формула для 
        //расчета такова: «среднемесячная заработная плата = 20.8 * 8 * почасовую ставку», для работников с 
        //фиксированной оплатой «среднемесячная заработная плата = фиксированной месячной оплате».

        //б) Создать на базе абстрактного класса массив сотрудников и заполнить его.

        //в) Реализовать интерфейсы для возможности сортировки массива используя Array.Sort().

        //г) Реализовать возможность вывода данных с использованием foreach
        static void Main(string[] args)
        {
            Workers a = new HourlyWorkers();
            Workers[] workers = new Workers[5];
            workers[0] = new HourlyWorkers();
            workers[0].Name = "Yorik";
            workers[0].Age = 22;
            workers[0].Gender = true;
            workers[0].YearOfReceipt = 2008;
            workers[0].Wage = 20000;
            workers[1] = new FixedWageWorkers();
            workers[1].Name = "Vadim";
            workers[1].Age = 25;
            workers[1].Gender = true;
            workers[1].YearOfReceipt = 2004;
            workers[1].Wage = 25000;
            workers[2] = new FixedWageWorkers();
            workers[2].Name = "Andrey";
            workers[2].Age = 19;
            workers[2].Gender = true;
            workers[2].YearOfReceipt = 2012;
            workers[2].Wage = 10000;
            workers[3] = new HourlyWorkers();
            workers[3].Name = "Ravshan";
            workers[3].Age = 30;
            workers[3].Gender = true;
            workers[3].YearOfReceipt = 1996;
            workers[3].Wage = 15000;
            workers[4] = new HourlyWorkers();
            workers[4].Name = "Jamshut";
            workers[4].Age = 26;
            workers[4].Gender = true;
            workers[4].YearOfReceipt = 1996;
            workers[4].Wage = 15000;
            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine(workers[i].Wage);
            }
            Console.WriteLine();
            for (int i = 0; i < workers.Length; i++)
            {
                for (int j = 0; j < workers.Length; j++)
                {
                    if (workers[i].Wage < workers[j].Wage)
                    {
                        a = workers[i];
                        workers[i] = workers[j];
                        workers[j] = a;
                    }
                }
            }
            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine(workers[i].Wage);
            }
        }
    }
}
