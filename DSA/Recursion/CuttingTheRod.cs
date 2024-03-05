using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA_GfG.DSA.Recursion
{
    public class CuttingTheRod
    {
        public int MaxPieces(int n, int a, int b, int c)
        {
            if (n == 0) return 0;
            if (n < -1) return -1;

            int res = Math.Max(MaxPieces(n - a, a, b, c), Math.Max(MaxPieces(n - b, a, b, c), MaxPieces(n - c, a, b, c)));
            if (res == -1) return -1;
            return res + 1;
        }
    }
}