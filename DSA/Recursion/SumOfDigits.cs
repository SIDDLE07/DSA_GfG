using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA_GfG.DSA.Recursion
{
    public class SumOfDigits
    {
        public int GetSumOfDigits(int n, int sum = 0){
            	if(n == 0) return sum;
	            else return GetSumOfDigits(n/10, sum+n%10);
        }
    }
}