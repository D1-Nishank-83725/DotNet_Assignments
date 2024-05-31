using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question18
{
    public class Math
    {
        public int Add(int x, int y)
        {
            Console.WriteLine("Invoked Add");
            return x + y;
        }
        public int Sub(int x, int y)
        {
            Console.WriteLine("Invoked Sub");
            return x - y;
        }
        public int Mul(int x, int y)
        {
            Console.WriteLine("Invoked Mul");
            return x * y;
        }
        public int Div(int x, int y)
        {
            Console.WriteLine("Invoked Div");
            if (y < 0)
                return 0;
            return x / y;
        }
    }
}

