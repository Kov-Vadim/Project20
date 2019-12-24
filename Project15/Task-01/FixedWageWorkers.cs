namespace Task_01
{
    class FixedWageWorkers :Workers
    {
        public string Skills { get; set; }
        public string Education { get; set; }
        public FixedWageWorkers(string name, int age, bool gender, int yearOfReceipt, double wage,string skills,string education) 
        : base (name, age, gender, yearOfReceipt,wage)
        {
            Skills = skills;
            Education = education;
        }
    }
}
