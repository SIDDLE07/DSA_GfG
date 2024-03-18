using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA_GfG.DSA.Patterns
{
    public class Patterns
    {
        public void P1(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void P2(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void P3(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(j + 1);
                }
                Console.WriteLine();
            }
        }

        public void P4(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(i + 1);
                }
                Console.WriteLine();
            }
        }

        public void P5(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void P6(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(j + 1);
                }
                Console.WriteLine();
            }
        }

        public void P7(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2 * n; j++)
                {
                    if (j >= n - i && j <= n + i)
                        Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public void P8(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2 * n; j++)
                {
                    if (j > 2 * n - (2 * i - 1))
                        Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}