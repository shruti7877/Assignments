using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8_Q3
{
    internal class Sum
    {
        public int solution(int[] A)
        {
            int s = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    break;
                }

                if (A[i] > 0)
                {
                    s += A[i];
                }
            }

            return s;
        }
    }
}
