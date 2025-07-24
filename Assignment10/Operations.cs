using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    internal class Operations
    {
        public static int Sum(params int?[] a)
        {
            int sum = 0; 
            foreach (var num in a) 
            {
                sum += num ?? 10; 
            }
            return sum; 
        }

        
        public static int Subtract(int a, int b)
        {
            return a - b; 
        }
        public static int Product(params int?[] a)
        {
            int pro = 1; 
            foreach (var num in a) 
            {
                pro *= num ?? 10; 
            }
            return pro; 
        }
        public static int Min(params int?[] a)
        {
            return a.Select(n => n ?? 10).Min();
        }

        public static int Max(params int?[] a)
        {
            return a.Select(n => n ?? 10).Max();
        }
        public static bool IsEven(int n)
        {
            return n % 2 == 0; 
        }

        public static bool IsOdd(int n)
        {
            return n % 2 != 0; 
        }
        public static bool IsPrime(int n)
        {
            if (n < 2)
                return false; 

            for (int i = 2; i < n; i++) 
            {
                if (n % i == 0) 
                    return false;
            }

            return true; 
        }



    }
}
