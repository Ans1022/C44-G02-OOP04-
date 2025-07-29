using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Static
{
    internal class Utilities
    {
        public int X { get; set; }
        public int Y { get; set; }
        private static double pi = 3.12 ;

        // Static Methods : Class Memeber Method
        public static double CmtoInch(double cm)
        {
            return cm / 2.45;
        }

        // 3.14
        // static Property
        public static double PI
        {

            get
            {
                return PI;
            }

        }

    }
}
