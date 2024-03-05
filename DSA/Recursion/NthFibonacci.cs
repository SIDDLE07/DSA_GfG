using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA_GfG.DSA.Recursion
{
    public class NthFibonacci
    {
        public int Fib(int n){
            // 0 1 1 2 3 5 7 12
            if(n == 0) return 0;
            if(n == 1) return 1;
            return Fib(n-1) + Fib(n-2);
        }
    }
}