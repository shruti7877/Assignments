using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8_Q1
{
    internal class Positive
    {
        public int Square(int[] A)
        {
            int smallest = int.MaxValue;
            bool found = false;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0 && A[i] < smallest)
                {
                    smallest = A[i];
                    found = true;
                }
            }

            if (found==true)
            {
                return smallest * smallest;
            }
            else
            {
                return 0;
            }

        }
    }
}
