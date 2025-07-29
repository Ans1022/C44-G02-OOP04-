using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Task
{
    internal class Food
    {
        public int FreshnessLevel { get; set; }

        public Food(int initialFreshness)
        {
            FreshnessLevel = initialFreshness;
        }

        public static Food operator ++(Food f)
        {
            f.FreshnessLevel++;
            return f;
        }

        public void Show()
        {
            Console.WriteLine("Freshness Level: " + FreshnessLevel);
        }
    }
}
