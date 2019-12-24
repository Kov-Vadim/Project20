using System;

namespace Task_04
{
    class Rectangle
    {
        public double side1;
        public double side2;
        private double area;
        private double perimetr;
        public double Area
        {
            get { return area; }
            private set { area = AreaCalculator(); }
        }
        public double Perimetr
        {
            get { return perimetr; }
            private set { perimetr = PerimeterCalculator(); }
        }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
            area = AreaCalculator();
            perimetr = PerimeterCalculator();
        }
        public double AreaCalculator()
        {
            return side1 * side2;
        }
        public double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }
    }
    class Program
    { //Создать класс с именем Rectangle, содержащий следующие поля:
      //- два поля, описывающие длины сторон double side1, side2.
      //- создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого поля side1 и 
      //side2 инициализируются значениями аргументов
      //Методы
      //- вычисление площади прямоугольника - double AreaCalculator()
      //- периметр прямоугольника - double PerimeterCalculator()
      //- Создать два свойства double Area и double Perimeter с одним методом доступа get
      //- Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на экран 
      //периметр и площадь.
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(new Random().Next(20), new Random().Next(20));
            Console.WriteLine(rectangle.side1 + " "+rectangle.side2 + " "+rectangle.Area+" "+rectangle.Perimetr);
        }
    }
}
