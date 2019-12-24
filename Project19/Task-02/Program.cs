using System;

namespace Task_02
{
    interface IPlayable
    {
        void Play();
        void PausePlay();
        void StopPlay();
    }
    interface IRecordable
    {
        void Record();
        void PauseRecord();
        void StopRecord();
    }
    class Player : IPlayable, IRecordable
    {
        public bool PP { get; set; }
        public bool PR { get; set; }
        public bool P { get; set; }
        public bool R { get; set; }
        public bool SP { get; set; }
        public bool SR { get; set; }
        public Player()
        {
            P = false;
            R = false;
            PP = false;
            PR = false;
            SP = true;
            SR = true;
        }
        public void PausePlay()
        {
            if (PP == true)
            {
                Console.WriteLine("Playback recording has already been paused");
            }
            else if(P==true)
            {
                Console.WriteLine("Record playback paused");
                PP = true;
                P = false;
            }
            else
            {
                Console.WriteLine("Record playback not started");
            }
        }
        public void PauseRecord()
        {
            if (PR == true)
            {
                Console.WriteLine("Recording has already been paused");
            }
            else if(R == true)
            {
                Console.WriteLine("Recording paused");
                PR = true;
                R = false;
            }
            else
            {
                Console.WriteLine("Information is not recorded");
            }
        }
        public void Play()
        {
            if (P == true)
            {
                Console.WriteLine("Record playback has already been started");
            }
            else
            {
                if (R == true | PR == true)
                {
                    StopRecord();
                }
                Console.WriteLine("Record playback started");
                P = true;
                PP = false;
                SP = false;
            }
        }
        public void Record()
        {
            if (R == true)
            {
                Console.WriteLine("Information is already being recorded");
            }
            else
            {
                if (P == true | PP == true)
                {
                    StopPlay();
                }
                Console.WriteLine("Information is being recorded");
                R = true;
                PR = false;
                SR = false;
            }
        }
        public void StopPlay()
        {
            if (SP == true)
            {
                Console.WriteLine("Record playback not started");
            }
            else
            {
                Console.WriteLine("Recording playback stopped");
                SP = true;
                PP = false;
                P = false;
            }
        }
        public void StopRecord()
        {
            if (SR == true)
            {
                Console.WriteLine("Information is not recorded");
            }
            else
            {
                Console.WriteLine("Information recording stopped");
                SR = true;
                PR = false;
                R = false;
            }
        }
    }
    class Program
    { //Создайте 2 интерфейса IPlayable и IRecodable.В каждом из интерфейсов создайте по 3 метода void Play() / void Pause() / void Stop() 
      //и void Record() / void Pause / void Stop() соответственно.
      //Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable.
      //Написать программу, которая выполнит проигрывание и запись.
        static void Main(string[] args)
        {
            Player player = new Player();
            Console.WriteLine("Player on");
            Console.WriteLine("Enter the method you need(1,2,3...or 8)\n1 : Play\n2 : Pause(Play)\n3 : Stop(Play)\n4 : Record\n5 : " +
                "Pause(Record)\n6 : Stop(Record)\n7 : Help\n8 : Exit");
            for(int i = 0; i < 1000; i++)
            {
                string a = Console.ReadLine();
                if (a == "1")
                {
                    player.Play();
                }
                else if (a == "2")
                {
                    player.PausePlay();
                }
                else if (a == "3")
                {
                    player.StopPlay();
                }
                else if (a == "4")
                {
                    player.Record();
                }
                else if (a == "5")
                {
                    player.PauseRecord();
                }
                else if (a == "6")
                {
                    player.StopRecord();
                }
                else if (a == "7")
                {
                    Console.WriteLine("1 : Play\n2 : Pause(Play)\n3 : Stop(Play)\n4 : Record\n5 : Pause(Record)\n6 : Stop(Record)\n7 : Help\n8 : Exit");
                }
                else if (a == "8")
                {
                    Console.WriteLine("Program completed");
                    break;
                }
                else
                {
                    Console.WriteLine("Error: invalid expression");
                    Console.WriteLine("If you forget how the methods are numbered, enter 7(7 : Help)");
                }
            }
        }
    }
}
