using System;

namespace Task_01
{
    class Tiles
    {
        public string brand;
        public double size_h;
        public double size_W;
        public double price;
        public Tiles(string brand,double size_h,double size_w,double price)
        {
            this.brand = brand;
            this.size_h = size_h;
            this.size_W = size_w;
            this.price = price;
        }
        public void getData()
        {
            Console.WriteLine($"Brand:{brand}\nSize H ={size_h}sm\nSize W ={size_W}sm\nPrice ={price} UAH\n");
        }
    }
    class Program
    { //Создать класс Tiles (кафель), который будет содержать поля с открытым доступом: brand, size_h, size_w, price и
      //метод класса getData(). В главной функции объявить пару объектов класса и внести данные в поля. Затем 
      //отобразить их, вызвав метод getData().
        static void Main(string[] args)
        {
            Tiles tiles1 = new Tiles("Azori", new Random().Next(5, 20), new Random().Next(5, 20), new Random().Next(500, 4000));
            Tiles tiles2 = new Tiles("CF-systems", new Random().Next(5, 20), new Random().Next(5, 20), new Random().Next(500, 4000));
            tiles1.getData();
            tiles2.getData();
        }
    }
}
