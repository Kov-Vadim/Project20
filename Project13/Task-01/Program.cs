using System;

namespace Task_01
{
    enum TypeOfCoffee
    {
        Late,
        Americano,
        Capuchino,
        Expresso
    }
    class CoffeeMaker
    {
        private int totalValueOfWater;
        private int totalCountOfSeed;
        private int totalValueOfMilk;
        private int totalValueOfSugare;

        private int valueOfWater;
        private int countOfSeed;
        private int valueOfMilk;
        private int valueOfSugare;
        private bool isOn;

        public int counter;
        public double price;
        public CoffeeMaker(int totalValueOfWater, int totalCountOfSeed, int totalValueOfMilk, int totalValueOfSugare)
        {
            this.totalValueOfWater = totalValueOfWater;
            this.totalCountOfSeed = totalCountOfSeed;
            this.totalValueOfMilk = totalValueOfMilk;
            this.totalValueOfSugare = totalValueOfSugare;
        }
        public int ValueOfWater { get =>valueOfWater;}
        public int CountOfSeed { get=>countOfSeed;}
        public int ValueOfMilk { get=>valueOfMilk;}
        public int ValueOfSugare { get=>valueOfSugare;}
        public bool IsOn { get=>isOn; set=>isOn=value; }
        public void MakeCoffee(TypeOfCoffee typeOfCoffee)
        {
            counter = 1;
            if (isOn==false)
            {
                switch (typeOfCoffee)
                {
                    case TypeOfCoffee.Americano:
                        valueOfWater = 100;
                        countOfSeed = 5;
                        price = 15;
                        if (totalCountOfSeed >= countOfSeed)
                            totalCountOfSeed -= countOfSeed;
                        else
                        {
                            Console.WriteLine($"The seeds are over. Please replenish stock");
                            counter -= 1;
                            break;
                        }
                        if (totalValueOfWater >= valueOfWater)
                            totalValueOfWater -= valueOfWater;
                        else
                        {
                            Console.WriteLine($"Watertank is empty.Please full tank");
                            counter -= 1;
                        }
                        break;
                    case TypeOfCoffee.Capuchino:
                        valueOfWater = 50;
                        countOfSeed = 5;
                        valueOfMilk = 50;
                        price = 20;
                        if (totalValueOfMilk >= valueOfMilk)
                            totalValueOfMilk -= valueOfMilk;
                        else
                        {
                            Console.WriteLine($"The milk is over.Please replenish stock");
                            counter -= 1;
                            break;
                        }
                        if (totalCountOfSeed >= countOfSeed)
                            totalCountOfSeed -= countOfSeed;
                        else
                        {
                            Console.WriteLine($"The seeds are over. Please replenish stock");
                            counter -= 1;
                            break;
                        }
                        if (totalValueOfWater >= valueOfWater)
                            totalValueOfWater -= valueOfWater;
                        else
                        {
                            Console.WriteLine($"Watertank is empty.Please full tank");
                            counter -= 1;
                        }
                            break;
                    case TypeOfCoffee.Expresso:
                        valueOfWater = 100;
                        countOfSeed = 5;
                        price = 18;
                        if (totalCountOfSeed >= countOfSeed)
                            totalCountOfSeed -= countOfSeed;
                        else
                        {
                            Console.WriteLine($"The seeds are over. Please replenish stock");
                            counter -= 1;
                            break;
                        }
                        if (totalValueOfWater >= valueOfWater)
                            totalValueOfWater -= valueOfWater;
                        else
                        { Console.WriteLine($"Watertank is empty.Please full tank");
                            counter -= 1;
                        }
                        Console.WriteLine("Add milk ?(+/-)");
                        string milk = Console.ReadLine();
                        if (milk == "+")
                        {
                            valueOfMilk = 50;
                            price += 3;
                            if (totalValueOfMilk >= valueOfMilk)
                                totalValueOfMilk -= valueOfMilk;
                            else
                            {
                                Console.WriteLine($"The milk is over.Please replenish stock");
                                counter -= 1;
                                break;
                            }
                        }
                        else if (milk == "-")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Wrong expression");
                            counter -= 1;
                        }

                            break;
                    case TypeOfCoffee.Late:
                        valueOfWater = 50;
                        countOfSeed = 5;
                        valueOfMilk = 50;
                        price = 22;
                        if (totalValueOfMilk >= valueOfMilk)
                            totalValueOfMilk -= valueOfMilk;
                        else
                        {
                            Console.WriteLine($"The milk is over.Please replenish stock");
                            counter -= 1;
                            break;
                        }
                        if (totalCountOfSeed >= countOfSeed)
                            totalCountOfSeed -= countOfSeed;
                        else
                        {
                            Console.WriteLine($"The seeds are over. Please replenish stock");
                            counter -= 1;
                            break;
                        }
                        if (totalValueOfWater >= valueOfWater)
                            totalValueOfWater -= valueOfWater;
                        else
                        { Console.WriteLine($"Watertank is empty.Please full tank");
                            counter -= 1;
                        }
                        break;
                }
            }
        }
        public void Sugar()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            valueOfSugare = a;
            price += a / 20;
            if (totalValueOfSugare >= valueOfSugare)
                totalValueOfSugare -= valueOfSugare;
            else
            { Console.WriteLine($"You have run out of sugar. Please replenish stock");
                counter -= 1;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMaker coffeeMaker = new CoffeeMaker(1000,500,700,250);
            Console.WriteLine($"What kind of coffee do you make?\n1:Late\n2:Americano\n3:Capuchino\n4:Expresso");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b == 1)
            {
                coffeeMaker.MakeCoffee(TypeOfCoffee.Late);
            }
            else if (b == 2)
            {
                coffeeMaker.MakeCoffee(TypeOfCoffee.Americano);
            }
            else if (b == 3)
            {
                coffeeMaker.MakeCoffee(TypeOfCoffee.Capuchino);
            }
            else if (b == 4)
            {
                coffeeMaker.MakeCoffee(TypeOfCoffee.Expresso);
            }
            else
            {
                Console.WriteLine($"Wrong expression");
                coffeeMaker.counter -= 1;
            }
            if (coffeeMaker.counter == 1)
            {
                Console.WriteLine($"How much sugar to add?");
                coffeeMaker.Sugar();
                if (coffeeMaker.counter == 1)
                {
                     Console.WriteLine($"Your coffee is ready.You are {coffeeMaker.price} UAH");
                }
            }
        }
    }
}
