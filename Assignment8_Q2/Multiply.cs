using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8_Q2
{
    internal class Multiply
    {
        public string solution(int N1, int N2, int Start, int End)
        {
            if (N1 <= 0 || N2 <= 0 || Start <= 0 || End <= 0)
            {
                return "0";
            }

            StringBuilder sb = new StringBuilder();

            for (int i = N1; i <= N2; i++)
            {
                for (int j = Start; j <= End; j++)
                {
                    sb.Append(i + " * " + j + " = " + (i * j) + "\n");
                }
            }

            return sb.ToString();
        }
    }

}

