using System;

namespace Task_01
{
    class GeometricFigure
    {
        public int NumberOfCorners;
        public int NumberOfParties;
        public double P { get; set; }
        public double S { get; set; }

    }
    class Triangle : GeometricFigure
    {
        public double[] Corners = new double[3];
        public Triangle()
        {
            NumberOfParties = 3;
            NumberOfCorners = 3;
            for (int i = 0; i < Corners.Length; i++)
            {
                Corners[i] = new Random().Next(5, 20);
            }
            P = Corners[0] + Corners[1] + Corners[2];
        }
    }
    class Pentagon : GeometricFigure
    {
        public double[] Corners = new double[5];
        public Pentagon()
        {
            NumberOfParties = 5;
            NumberOfCorners = 5;
            for (int i = 0; i < Corners.Length; i++)
            {
                Corners[i] = new Random().Next(5, 20);
            }
        }
    }
    class Rhombus : GeometricFigure
    {
        public double[] Corners = new double[4];
        public Rhombus()
        {
            NumberOfParties = 4;
            NumberOfCorners = 4;
            for (int i = 0; i < Corners.Length; i++)
            {
                Corners[i] = new Random().Next(5, 20);
            }
        }
    }
    class Circle : GeometricFigure
    {
        public double R { get; set; } 
        public Circle()
        {
            NumberOfParties = 0;
            NumberOfCorners = 0;
            R = new Random().Next(5, 20);
        }
    }
    class Program
    { //Описать сущность геометрическая фигура. Используйте инкапсуляцию, наследование,полиморфизм для описания 
      //треугольника, пятиугольника, ромба и круга. Создайте методы, вычисляющие периметр, площадь, радиус, если 
      //необходимо всех фигур. Также напишите перегрузку операторов сравнения для выявления наибольшой фигуры по 
      //площадям, периметрам и т.д
        static void Main(string[] args)
        {
            
        }
    }
}
