using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA_GfG.DSA.Recursion
{
    public class RecursivePrint
    {
        public void PrintNto1(int n)
        {
            if (n <= 0) return;
            Console.WriteLine(n);
            PrintNto1(n - 1);
        }
        public void Print1toN(int n)
        {
            if (n <= 0) return;
            Print1toN(n - 1);
            Console.WriteLine(n);
        }

    }
}