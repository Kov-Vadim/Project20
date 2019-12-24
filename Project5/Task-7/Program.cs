using System;

namespace Task_7
{
    class Program
    { //Дано вещественное число — цена 1 кг конфет. Вывести стоимость 1.2, 1.4, …, 2 кг конфет.​
        static void Main(string[] args)
        {
            var UAH_kg = Convert.ToDouble(new Random().Next(1000) / 10.0);
            Console.WriteLine($"{UAH_kg} UAH/kg\n");
            double j = 0;
            for (double i = 1.2; i <= 2.0; i+=0.2)
            {
                j =i * UAH_kg ;
                Console.WriteLine($"{j / UAH_kg} kg={j} UAH");
            }
            
        }
    }
}
