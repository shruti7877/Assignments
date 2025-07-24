using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    public static class NumExtensions
    {
        public static void DisplayEven(this int start, int end)
        {
            for (int i = start; i <= end; i++) 
                if (i % 2 == 0) 
                    Console.WriteLine(i + " ");    
        }
        public static void DisplayOdd(this int start, int end)
        {
            for (int i = start; i <= end; i++) 
                if (i % 2 != 0) 
                    Console.WriteLine(i + " "); 
        }
        public static void DisplayPrimes(this int start, int end)
        {
            for (int i = start; i <= end; i++) 
                if (Operations.IsPrime(i)) 
                    Console.WriteLine(i + " "); 
        }
        public static void DisplayTable(this int n)
        {
            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine(n + " x " + i + " = " + (n * i));
            }
        }
        public static void DisplayTables1To10(this int start, int end)
        {
            for (int n = start; n <= end; n++)
            {
                Console.WriteLine("Table of " + n + ":");
                n.DisplayTable(); 
            }
        }
        public static void ReverseNumber(this int n)
        {
            int rev = 0; 

            while (n != 0) 
            {
                rev = rev * 10 + n % 10; 
                n /= 10; 
            }

            Console.WriteLine("Reversed number is : " + rev); 
        }
    }
}
