using System;

namespace Task_01
{
    class Workers
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public int YearOfReceipt { get; set; }
        public double Wage { get; set; }
        public Workers(string name,int age,bool gender,int yearOfReceipt,double wage)
        {
            Wage = wage;
            Name = name;
            Age = age;
            Gender = gender;
            YearOfReceipt = yearOfReceipt;
            
        }
    }
    class Program
    { //Построить три класса (базовый и 2 потомка), описывающих некоторых работников с почасовой оплатой (один из 
      //потомков) и фиксированной оплатой (второй потомок).

        //а) Описать в базовом классе метод для расчета среднемесячной заработной платы.Для «повременщиков» формула для 
        //расчета такова: «среднемесячная заработная плата = 20.8 * 8 * почасовую ставку», для работников с 
        //фиксированной оплатой «среднемесячная заработная плата = фиксированной месячной оплате».

        //б) Создать на базе класса массив сотрудников и заполнить его.

        //в) Реализовать метод для возможности сортировки массива.

        //г) Реализовать возможность вывода данных с использованием foreach
        static void Main(string[] args)
        {
            Workers a = new Workers("",1,true,1,1);
            Workers[] workers = new Workers[5];

            workers[0] = (new Workers("Yorik", 22, true, 2008, 20000));
            workers[1] = (new Workers("Vadim", 25, true, 2004,25000));
            workers[2] = (new Workers("Andrey", 19, true, 2012, 10000));
            workers[3] = (new Workers("Ravshan", 30, true, 1996, 15000));
            workers[4] = (new Workers("Jamshud", 26, true, 1996, 15000));
            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine(workers[i].Wage);
            }
            Console.WriteLine();
            for (int i = 0; i< workers.Length; i++) 
            {
                for (int j=0;j<workers.Length;j++)
                {
                    if (workers[i].Wage<workers[j].Wage)
                    {
                        a = workers[i];
                        workers[i] = workers[j];
                        workers[j] = a;
                    }
                } 
            }
            for(int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine(workers[i].Wage);
            }
        }
    }
}
