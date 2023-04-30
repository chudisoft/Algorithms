using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class Program
    {
        void main()
        {

            string s = "ssdhhharaeeeetawweees";
            var result = CharCountClass.CharCount(s);

            int[] newNums = { 1, 2, 3, 4, 5 };
            var result2 = NumFlipClass.NumFlip(newNums);
            Console.ReadLine();
        }
    }
}
