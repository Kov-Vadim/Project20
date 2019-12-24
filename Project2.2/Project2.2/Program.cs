using System;

namespace Project2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("name:");
            string name = Console.ReadLine();
            Console.WriteLine("surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("patronymic:");
            string patronymic = Console.ReadLine();
            Console.WriteLine("ageOfPerson:");
            byte ageOfPerson = byte.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Data:");
            Console.WriteLine(" name:" + name + "\n surname:" + surname + "\n patronymic:" + patronymic + "\n ageOfPerson:"
            + ageOfPerson);
        }
    }
}
