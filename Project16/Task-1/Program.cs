using System;

namespace Task_01
{
    class Calculator
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }
        public Calculator(double a,double b)
        {
            A = a;
            B = b;
        }
        public void Multiplication()
        {
            C = A * B;
            Console.WriteLine($"{A}*{B}={C}\n");
        }
        public void Division()
        {
            C = A / B;
            Console.WriteLine($"{A}/{B}={C}\n");
            D = B / A;
            Console.WriteLine($"{B}/{A}={D}\n");
        }
        public void Addition()
        {
            C = A + B;
            Console.WriteLine($"{A}+{B}={C}\n");
        }
        public void Subtraction()
        {
            C = A - B;
            Console.WriteLine($"{A}-{B}={C}\n");
            D = B - A;
            Console.WriteLine($"{B}-{A}={D}\n");
        }
    }
    class Program
    { //Создать статический класс Calculator, с методами для выполнения основных арифметических операцый. Написать программу, которая выводит на 
      //экран основные арифметические операции.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers A and B");
            Console.Write("A=");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("B=");
            double m = Convert.ToDouble(Console.ReadLine());
            Calculator calculator = new Calculator(k,m);
            calculator.Multiplication();
            calculator.Division();
            calculator.Addition();
            calculator.Subtraction();

        }
    }
}
