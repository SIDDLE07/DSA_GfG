using System;
using DSA;
using DSA_GfG.DSA;
using DSA_GfG.DSA.core;
using DSA_GfG.DSA.Recursion;

class Program
{
    public static void Main(string[] args)
    {
        //new RangeSum(new int[]{1,2,3,4,5,6} ,2,4);
        //new BasicMathematicsPrograms();

        /**/
        //ListNode ll = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, null))));

        // var rll =new RecursiveReverseLL().ReverseList(ll);
        // while(rll.next!=null){
        //   Console.WriteLine(rll.val);
        // }


        //new RecursivePrint().PrintNto1(5);
        //new RecursivePrint().Print1toN(5);
        //Console.WriteLine(new NthFibonacci().Fib(5));

        //Console.WriteLine(new SumNaturalNumber().GetSumNonTailRecursive(5));
        //Console.WriteLine(new SumNaturalNumber().GetSumTailRecursive(3, 0));
        //Console.WriteLine(new SumOfDigits().GetSumOfDigits(1234));
        //Console.WriteLine(new CuttingTheRod().MaxPieces(23, 12, 9, 11));
        //new SubsetOfString().GenerateSubset("ABC");
        Console.WriteLine(new SubsetSumEqualToK().CountSubset(new int[] { 10, 20, 15 }, 3, 25));
        Console.WriteLine(new SubsetSumEqualToK().CountSubset(new int[] { 10, 5, 2, 3, 6 }, 5, 8));

    }
}

