﻿namespace Task_01
{
    class HourlyWorkers : Workers
    {
        public double Speed { get; set; }
        public double HourlyWage { get; set; }
        public double WageCalkulator()
        {
            return Wage / 20.8 / 8;
        }
        public HourlyWorkers(string name, int age, bool gender, int yearOfReceipt, double wage, double speed)
        :base(name,age,gender,yearOfReceipt,wage)
        {
            HourlyWage = WageCalkulator();
            Speed = speed;
        }
    }
}
