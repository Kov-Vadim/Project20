using System;
using System.Collections.Generic;
using System.Text;

namespace Task_01
{
    class Animals
    {
        public string coloring { get; set; }
        public string emittedSound { get; set; }
        public string ability { get; set; }
        public double power { get; set; }
        public double size { get; set; }
        public double speed { get; set; }
        public void EmittedSound()
        {
            Console.WriteLine(emittedSound);
        }
    }
    class Fish : Animals
    {
        public double depthOfHabitat { get; set; }
        public bool saltOrFreshWater { get; set; }

    }
    class Birds : Animals
    {
        public bool flyingOrNonFlying { get; set; }
        public bool migratory { get; set; }
        public bool wildOrDomestic { get; set; }
    }
    class Amphibians : Animals
    {

    }
    class Reptiles : Animals
    {

    }
    class Mammals : Animals
    {

    }
}
