using System;

namespace Task_02
{
    class Children
    {
        private string name;
        private string surname;
        private int age;
        public Children(string name,string surname,int age )
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        public void getData()
        {
            Console.WriteLine($"Name:{name}\nSurname:{surname}\nAge:{age}\n");
        }
    }
    class Program
    { //Определить класс Children, который содержит такие поля (члены класса): закрытые – имя ребенка, фамилию и 
      //возраст , публичные – методы ввода данных и отображения их на экран. Объявить два объекта класса, внести 
      //данные и показать их. 

        static void Main(string[] args)
        {
            Children child1 = new Children("Vadim", "Kovalenko", 15);
            Children child2 = new Children("Sasha", "Shitina", 14);
            child1.getData();
            child2.getData();
            
        }
    }
}
