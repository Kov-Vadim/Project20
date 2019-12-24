using System;

namespace Task_01
{
    abstract class AbstractHandler
    {
        public bool a { get; set; }
        public bool b { get; set; }
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }
    class XMLHandler : AbstractHandler
    {
        public string xml { get; set; }
        public override void Change()
        {
            if (b == false)
            {
                Create();
            }
            Console.WriteLine("Enter the data you want to change the XML document to");
            xml = Console.ReadLine();
            Console.WriteLine("XML document modified");
        }
        public override void Create()
        {
            if (a == false)
            {
                Open();
            }
            b = true;
            Console.WriteLine("Enter the contents of the XML document");
            xml = Console.ReadLine();
            Console.WriteLine("XML document created");
        }
        public override void Open()
        {
            if (a == true)
            {
                Console.WriteLine("TML Raider app is already open");
            }
            else
            {
                Console.WriteLine("TML Raider app open");
                a = true;
            }
        }
        public override void Save()
        {
            if (b == false)
            {
                Console.WriteLine("To save a XML document it needs to be changed");
            }
            else
            {
                Console.WriteLine("XML document saved");
                a = false;
                b = false;
            }
        }
    }
    class TXTHandler : AbstractHandler
    {
        public string txt { get; set; }
        public override void Change()
        {
            if (b == false)
            {
                Create();
            }
            Console.WriteLine("Enter the data you want to change the text document to");
            txt = Console.ReadLine();
            Console.WriteLine("Text document modified");
        }
        public override void Create()
        {
            if (a == false)
            {
                Open();
            }
            b = true;
            Console.WriteLine("Enter the contents of the text document");
            txt = Console.ReadLine();
            Console.WriteLine("Text document created");
        }
        public override void Open()
        {
            if (a == true)
            {
                Console.WriteLine("TXT Raider app is already open");
            }
            else
            {
                Console.WriteLine("TXT Raider app open");
                a = true;
            }
        }
        public override void Save()
        {
            if (b == false)
            {
                Console.WriteLine("To save a text document it needs to be changed");
            }
            else
            {
                Console.WriteLine("Text document saved");
                a = false;
                b = false;
            }
        }
    }
    class DOCHandler : AbstractHandler
    {
        public string doc { get; set; }
        public override void Change()
        {
            if (b == false)
            {
                Create();
            }
            Console.WriteLine("Enter the data you want to change the document to");
            doc = Console.ReadLine();
            Console.WriteLine("Document modified");
        }
        public override void Create()
        {
            if (a == false)
            {
                Open();
            }
            b = true;
            Console.WriteLine("Enter document content");
            doc = Console.ReadLine();
            Console.WriteLine("Document created");
        }
        public override void Open()
        {
            if (a == true)
            {
                Console.WriteLine("DOC Raider app is already open");
            }
            else
            {
                Console.WriteLine("DOC Raider app open");
                a = true;
            }
        }
        public override void Save()
        {
            if (b == false)
            {
                Console.WriteLine("To save a document it needs to be changed");
            }
            else
            {
                Console.WriteLine("Document saved");
                a = false;
                b = false;
            }
        }
    }
    class Program
    { //Создайте класс AbstractHandler.В теле класса создать методы void Open(), void Create(), void Change(), void Save().Создать производные 
      //классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler.

      //Написать программу, которая будет выполнять определения документа и для каждого формата должны быть методы открытия, создания, 
      //редактирования, сохранения определенного формата документа.
        static void Main(string[] args)
        {
            Console.WriteLine("Select handler type(1,2 or 3)\n1 : XML Handler\n2 : TXT Handler\n3 : DOC Handler");
            for (int i = 0; i < 500; i++)
            {
                string type = Console.ReadLine();
                if (type == "1")
                {
                    AbstractHandler handler = new XMLHandler();
                    Console.WriteLine("Select method (1,2,3 or 4)\n1 : Open\n2 : Create\n3 : Change\n4 : Save");
                    for (int j = 0; j < 1000; j++)
                    {
                        string metod = Console.ReadLine();
                        if (metod == "1")
                        {
                            handler.Open();
                        }
                        else if (metod == "2")
                        {
                            handler.Create();
                        }
                        else if (metod == "3")
                        {
                            handler.Change();
                        }
                        else if (metod == "4")
                        {
                            handler.Save();
                            Console.WriteLine("Want to complete the program?(1 or 2)\n1 : Yes\n2 : No");
                            string a = Console.ReadLine();
                            if (a == "1")
                            {
                                break;
                            }
                            else if (a == "2")
                            {

                            }
                            else
                            {
                                Console.WriteLine("Error: invalid expression");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error: invalid expression");
                        }
                    }
                    break;
                }
                else if (type == "2")
                {
                    AbstractHandler handler = new TXTHandler();
                    Console.WriteLine("Select method (1,2,3 or 4)\n1 : Open\n2 : Create\n3 : Change\n4 : Save");
                    for (int j = 0; j < 1000; j++)
                    {
                        string metod = Console.ReadLine();
                        if (metod == "1")
                        {
                            handler.Open();
                        }
                        else if (metod == "2")
                        {
                            handler.Create();
                        }
                        else if (metod == "3")
                        {
                            handler.Change();
                        }
                        else if (metod == "4")
                        {
                            handler.Save();
                            Console.WriteLine("Want to complete the program?(1 or 2)\n1 : Yes\n2 : No");
                            string a = Console.ReadLine();
                            if (a == "1")
                            {
                                break;
                            }
                            else if (a == "2")
                            {

                            }
                            else
                            {
                                Console.WriteLine("Error: invalid expression");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error: invalid expression");
                        }
                    }
                    break;
                }
                else if (type == "3")
                {
                    AbstractHandler handler = new DOCHandler();
                    Console.WriteLine("Select method (1,2,3 or 4)\n1 : Open\n2 : Create\n3 : Change\n4 : Save");
                    for (int j = 0; j < 1000; j++)
                    {
                        string metod = Console.ReadLine();
                        if (metod == "1")
                        {
                            handler.Open();
                        }
                        else if (metod == "2")
                        {
                            handler.Create();
                        }
                        else if (metod == "3")
                        {
                            handler.Change();
                        }
                        else if (metod == "4")
                        {
                            handler.Save();
                            Console.WriteLine("Want to complete the program?(1 or 2)\n1 : Yes\n2 : No");
                            string a = Console.ReadLine();
                            if (a == "1")
                            {
                                break;
                            }
                            else if (a == "2")
                            {

                            }
                            else
                            {
                                Console.WriteLine("Error: invalid expression");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error: invalid expression");
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Error: invalid expression");
                }
            }
        }
    }
}
