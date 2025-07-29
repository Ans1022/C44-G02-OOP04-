using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Sealed
{
    internal class TypeA
    {
        public virtual int X { get; set; }
        public virtual void Fun01()
        {
            Console.WriteLine("I am Fun From TypeA ");
        }
    }
}
