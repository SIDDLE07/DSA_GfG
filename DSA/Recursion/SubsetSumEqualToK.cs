using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA_GfG.DSA.Recursion
{
    public class SubsetSumEqualToK
    {
        // Count the number of Subsets whose sum is equal to the given value of K
        public int CountSubset(int[] arry, int n, int sum)
        {
            if (n == 0) return (sum == 0) ? 1 : 0;
            return CountSubset(arry, n - 1, sum) + CountSubset(arry, n - 1, sum - arry[n - 1]);
        }
    }
}