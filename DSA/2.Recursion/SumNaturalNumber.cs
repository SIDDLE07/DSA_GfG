namespace DSA_GfG.DSA
{
    public class SumNaturalNumber
    {
        public int GetSum(int n)
        {
            if (n == 0) return 0;
            return n + GetSum(n - 1);
        }
    }
}