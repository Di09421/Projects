using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Rect
    {
        int l,b;

        public int L { get => l; set => l = value; }
        public int B { get => b; set => b = value; }

        public int Area()
        {
            return l * b;
        }
        public int Peri()
        {
            return 2*(l + b);
        }
    }
}
