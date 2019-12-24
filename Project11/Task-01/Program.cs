using System;

namespace Task_01
{
    class Order
    {
        public double PayerAccount;
        public double BeneficiarysAccount;
        public double amountUAH;
        private double amountDollar;
        private double amountEuro;
        public double AmouthDollar
        {
            get { return amountDollar; }
            set { amountDollar = TransferAmouthDollar(); }
        }
        public double AmouthEuro
        {
            get { return amountEuro; }
            set { amountEuro = TransferAmouthEuro(); }
        }
        public Order(double payerAccount,double beneficiarysAccount,double AmountUAH)
        {
            PayerAccount = payerAccount;
            BeneficiarysAccount = beneficiarysAccount;
            amountUAH = AmountUAH;
            amountDollar = TransferAmouthDollar();
            amountEuro = TransferAmouthEuro();
        }
        public double TransferAmouthDollar()
        {
            return amountUAH / 1000 * 41;
        }
        public double TransferAmouthEuro()
        {
            return amountUAH / 1000 * 41;
        }
    }
    class Program
    { //Определить класс с именем Order содержащий следующие поля:
      //- расчетный счет плательщика(формат уточнить в Интернете);
      //- расчетный счет получателя;
      //- перечисляемая сумма в грн, $, евро
      //Методы:
      //- упорядочить по убыванию перечисляемой суммы;
      //- вывод информации о тех плательщиках, перечисляемая сумма которых не меньше суммы, введенной пользователем.
      //- ввод данных в массив из n элементов типа Order в Main;
        static void Main(string[] args)
        {
            int b;
            Order a = new Order(0,0,0);
            Order[] order = new Order[3];
            order[0] = (new Order(new Random().Next(1, 1000000000) * 10000 + new Random().Next(10000), new Random().Next(1, 1000000000) * 10000 + new Random().Next(10000), new Random().Next(500)));
            order[1] = (new Order(new Random().Next(1, 1000000000) * 10000 + new Random().Next(10000), new Random().Next(1, 1000000000) * 10000 + new Random().Next(10000), new Random().Next(500)));
            order[2] = (new Order(new Random().Next(1, 1000000000) * 10000 + new Random().Next(10000), new Random().Next(1, 1000000000) * 10000 + new Random().Next(10000), new Random().Next(500)));

            for(int i = 0; i < order.Length; i++)
            {
                Console.WriteLine(order[i].amountUAH);
            }
            Console.WriteLine();
            for(int i = 0; i < order.Length; i++)
            {
                for (int j = 0; j < order.Length; j++)
                {
                    if (order[i].amountUAH < order[j].amountUAH)
                    {
                        a.amountUAH = order[i].amountUAH;
                        order[i].amountUAH = order[j].amountUAH;
                        order[j].amountUAH = a.amountUAH;
                    }
                }
            }
            for (int i = 0; i < order.Length; i++)
            {
                Console.WriteLine(order[i].amountUAH);
            }
            Console.WriteLine();
            for (int i = 0; i < 1; i++)
            {
                b = 0;
                Console.Write("Enter amouth:");
                double z=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                for (int j = 0; j < order.Length; j++)
                {
                    if (order[j].amountUAH >= z)
                    {
                        Console.WriteLine($"PayerAccount:{order[j].PayerAccount}\nBeneficiarysAccount:{order[j].BeneficiarysAccount}");
                        b++;
                    }
                    else if (j == order.Length - 1 & order[j].amountUAH < z & b == 0)
                    {
                        Console.WriteLine("Error!\nPayments with such a large amount were not found.Try again");
                    }

                }
            }
        }
    }
}
