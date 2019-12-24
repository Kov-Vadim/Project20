using System;

namespace Tasc_01
{
    class Footballers
    {
        public string Name { get; set; }
        public int FootballerNumber { get; set; }
    }
    class People
    {
        public Footballers[] data;
        public Footballers this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
        public People()
        {
            data = new Footballers[11];
        }
    }
    class Program
    { //Определите класс футболиста, который содержит имя футболиста и его номер на поле. И определите класс футбольной команды, который 
      //хранит 11 футболистов в виде массива и обеспечивает доступ к этим футболистам через индексатор.
        static void Main(string[] args)
        {
            People footballers = new People();
            footballers[0] = new Footballers() { FootballerNumber = 1, Name = "Artem" };
            footballers[1] = new Footballers() { FootballerNumber = 2, Name = "Vadim" };
            footballers[2] = new Footballers() { FootballerNumber = 3, Name = "Bogdan" };
            footballers[3] = new Footballers() { FootballerNumber = 4, Name = "Andrey" };
            footballers[4] = new Footballers() { FootballerNumber = 5, Name = "Sergey" };
            footballers[5] = new Footballers() { FootballerNumber = 6, Name = "Danil" };
            footballers[6] = new Footballers() { FootballerNumber = 7, Name = "Sasha" };
            footballers[7] = new Footballers() { FootballerNumber = 8, Name = "Kiril" };
            footballers[8] = new Footballers() { FootballerNumber = 9, Name = "Lesha" };
            footballers[9] = new Footballers() { FootballerNumber = 10, Name = "Dima" };
            footballers[10] = new Footballers() { FootballerNumber = 11, Name = "Roma" };
            for(int i = 0; i < 11; i++)
            {
                Console.WriteLine($"Footballer Number {footballers[i].FootballerNumber} , Name:{footballers[i].Name}");
            }

        }
    }
}
