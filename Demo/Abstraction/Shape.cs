using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    // Abstract Class : Partial Class [Not Fully Implemented]
    // Concert Class : Fully Implemented Class
    internal abstract class Shape
    {
        public double Dim01 { get; set; }
        public double Dim02 { get; set; }

        // Abstract methods
        public abstract double GetArea();

        // Abstract properties
        public abstract double Perimeter { get; }


        public void Print()
        {
            Console.WriteLine($"I'am Shape");
        }
    }
}

    

