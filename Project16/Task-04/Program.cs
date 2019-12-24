using System;

namespace Task_04
{
    class DataBaseConnection
    {
        private static DataBaseConnection instanse;
        protected DataBaseConnection() { }
        public static DataBaseConnection ConnectionToDB()
        {
            if (instanse == null)
            {
                instanse = new DataBaseConnection();
                Console.WriteLine("Connection is created");
            }
            else
            {
                Console.WriteLine("Connection is already exists");
            }
            return instanse;
        }
    }
    class Program
    { //Изучить Singelton. Создать класс, где необходимо подключить базу данных в проект и класс, который будет отвечать за соединение с ней. Один 
      //раз создается соединение и нет нужды создавать его снова и снова.
        static void Main(string[] args)
        {
            DataBaseConnection db = DataBaseConnection.ConnectionToDB();
            DataBaseConnection db2 = DataBaseConnection.ConnectionToDB();
        }
    }
}
