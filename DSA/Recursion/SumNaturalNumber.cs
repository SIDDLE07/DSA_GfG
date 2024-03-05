using System.ComponentModel.DataAnnotations;

namespace DSA_GfG.DSA
{
    public class SumNaturalNumber
    {
        public int GetSumNonTailRecursive(int n)
        {
            if (n == 0) return 0;
            return n + GetSumNonTailRecursive(n - 1);
        }

        public int GetSumTailRecursive(int n, int k)
        {
            if (n == 0) return k;
            return GetSumTailRecursive(n - 1, k + n);
        }
    }
}