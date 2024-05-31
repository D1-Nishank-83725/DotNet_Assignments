using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question18
{
    public delegate int MathSDelegate(int x,int y);
    public  class Program
    {
        static void Main(string[] args)
        {
            MathSDelegate deleSA = new MathSDelegate(MathStatic.Add);
            MathSDelegate deleSS = new MathSDelegate(MathStatic.Add) + new MathSDelegate(MathStatic.Sub);
            MathSDelegate deleSM = new MathSDelegate(MathStatic.Mul);
            MathSDelegate deleSD = new MathSDelegate(MathStatic.Mul) + new MathSDelegate(MathStatic.Div);
            Console.WriteLine("Enter Two Numbers");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("For Static Math Class::");
            Console.WriteLine("Result of Uni-Cast Delegate SA:"+ deleSA(x,y));
            Console.WriteLine("Result of Multicast Delegate SS:" + deleSS(x, y));
            Console.WriteLine("Result of Uni-Cast Delegate SM:" + deleSM(x, y));
            Console.WriteLine("Result of Nulticast Delegate SD:" + deleSD(x, y));

            MathSDelegate deleMA = new MathSDelegate(MathStatic.Add);
            MathSDelegate deleMS = new MathSDelegate(MathStatic.Add) + new MathSDelegate(MathStatic.Sub);
            MathSDelegate deleMM = new MathSDelegate(MathStatic.Mul);
            MathSDelegate deleMD = new MathSDelegate(MathStatic.Mul) + new MathSDelegate(MathStatic.Div);
            Console.WriteLine(" ");
            Console.WriteLine("For Math Class::");
            Console.WriteLine("Result of Uni-Cast Delegate MA:" + deleSA(x, y));
            Console.WriteLine("Result of Multicast Delegate MS:" + deleSS(x, y));
            Console.WriteLine("Result of Uni-Cast Delegate MM:" + deleSM(x, y));
            Console.WriteLine("Result of Nulticast Delegate MD:" + deleSD(x, y));
        }
    }
}
#region Code-Output
/*
Enter Two Numbers
5
2
For Static Math Class::
Invoked Add
Result of Uni-Cast Delegate SA:7
Invoked Add
Invoked Sub
Result of Multicast Delegate SS:3
Invoked Mul
Result of Uni-Cast Delegate SM:10
Invoked Mul
Invoked Div
Result of Nulticast Delegate SD:2

For Math Class::
Invoked Add
Result of Uni-Cast Delegate MA:7
Invoked Add
Invoked Sub
Result of Multicast Delegate MS:3
Invoked Mul
Result of Uni-Cast Delegate MM:10
Invoked Mul
Invoked Div
Result of Nulticast Delegate MD:2
 */
#endregion
