using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Sealed
{
    internal class TypeB : TypeA
    {

        public int B { get; set; }
        public sealed override int X { get => base.X; set => base.X = value; }

        public sealed override void Fun01()
        {
            base.Fun01();
        }
    }
}
