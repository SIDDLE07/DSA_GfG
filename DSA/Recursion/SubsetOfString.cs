using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA_GfG.DSA.Recursion
{
    public class SubsetOfString
    {
        public void GenerateSubset(string s, string currentString = "", int index = 0)
        {
            if (index == s.Length)
            {
                Console.WriteLine(currentString);
                return;
            }
            GenerateSubset(s, currentString, index + 1);
            GenerateSubset(s, currentString + s[index], index + 1);
        }
    }
}