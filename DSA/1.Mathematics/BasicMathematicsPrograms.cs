using System;

namespace DSA{
  public class BasicMathematicsPrograms{
    public BasicMathematicsPrograms(){
      Console.WriteLine(CountFactors(36));
    }

    public void PrimeNumber(){
      // A prime number is a natural number greater than 1, which is only divisible by 1 and itself.
    }
    public int CountFactors(int num){
      int factorCount = 0;
      int sqr = (int)Math.Sqrt(num);
      for(int i=1;i<sqr;i++){
        if(num%i == 0){
          factorCount++;
          if((num%i)!=i){
            factorCount++;
          }
        }
      }
      return factorCount;
    }
  }
}
