using System;

namespace DSA
{
  public class Mathematics
  {
    public void PrimeNumber()
    {
      // A prime number is a natural number greater than 1, which is only divisible by 1 and itself.
    }
    public int CountFactors(int num)
    {
      int factorCount = 0;
      int sqr = (int)Math.Sqrt(num);
      for (int i = 1; i < sqr; i++)
      {
        if (num % i == 0)
        {
          factorCount++;
          if ((num % i) != i)
          {
            factorCount++;
          }
        }
      }
      return factorCount;
    }

    public int CalculateFactorial(int n)
    {
      int res = 1;
      for (int i = 2; i <= n; i++)
      {
        res *= i;
      }
      return res;
    }

    public int CalculateFactorialRecursive(int n)
    {
      if (n == 0) return 1;
      return n * CalculateFactorialRecursive(n - 1);
    }

  }
}
