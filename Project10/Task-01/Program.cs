using System;

namespace Task_01
{
    class Program
    { //Составить программу обмена значениями трех переменных величин а, b, c строкового типа по следующей схеме: а) 
      //b присвоить значение c, а присвоить значение b, c присвоить значение а; б) b присвоить значение а, с 
      //присвоить значение b, а присвоить значение c​
        static void Main(string[] args)
        {
            string a = "Hello", b = "Bye", c = "Goodmorning";
            Console.WriteLine($"a={a}\nb={b}\nc={c}");
            Console.WriteLine("A):");
            {
                string d = b;
                b = c;
                c = a;
                a = d;
                Console.WriteLine($"a={a}\nb={b}\nc={c}");
            }
            a = "Hello";
            b = "Bye";
            c = "Goodmorning";
            Console.WriteLine("B):");
            {
                string d = b;
                b = a;
                a = c;
                c = d;
                Console.WriteLine($"a={a}\nb={b}\nc={c}");
            }
        }
    }
}
