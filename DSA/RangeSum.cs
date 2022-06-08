using System;

namespace DSA{
  public class RangeSum {
  public RangeSum(int[] arry, int startIndex, int endIndex){
    int sum = 0;
    for(int i=0;i<arry.Length;i++){
      arry[i]+=sum;
      sum = arry[i];

      Console.WriteLine(arry[i]);
    }
    
    }
  }
}
