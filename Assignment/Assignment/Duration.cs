using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Assignment
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
    

     public Duration(int h, int m, int s)
        {
            Hours = h;
            Minutes = m;
            Seconds = s;
            Normalize();
        }

        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
        }

        private void Normalize()
        {
            Minutes += Seconds / 60;
            Seconds = Seconds % 60;
            Hours += Minutes / 60;
            Minutes = Minutes % 60;
        }

        public override string ToString()
        {
            string result = "";
            if (Hours > 0) result += "Hours: " + Hours + ", ";
            if (Minutes > 0 || Hours > 0) result += "Minutes :" + Minutes + ", ";
            result += "Seconds :" + Seconds;
            return result;
        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration
                (d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
        }

        public static Duration operator +(Duration d1, int seconds)
        {
            return new Duration
                (d1.Hours, d1.Minutes, d1.Seconds + seconds);
        }

        public static Duration operator +(int seconds, Duration d1)
        {
            return d1 + seconds;
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration
                (d.Hours, d.Minutes + 1, d.Seconds);
        }

        public static Duration operator --(Duration d)
        {
            return new Duration
                (d.Hours, d.Minutes - 1, d.Seconds);
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            int total1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int total2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            int diff = Math.Max(0, total1 - total2);
            return new Duration(diff);
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            return ((d1.Hours * 3600) + (d1.Minutes * 60) + d1.Seconds) > (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
                   
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return !(d1 > d2);
        }
    }
}
