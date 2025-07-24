using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class OnPayroll:Employee
    {
        private string JoiningDate;
        private int Experience;
        private double BasicSalary;

        public double DA, HRA, PF, NetSalary;

        public OnPayroll(int EmpID, string Name, string ReportingManager, string JoiningDate, int Experience, double BasicSalary)
           : base(EmpID, Name, ReportingManager)
        {
            this.JoiningDate = JoiningDate;
            this.Experience = Experience;
            this.BasicSalary = BasicSalary;
        }
        private void CalculateSalary()
        {
            if (Experience > 10)
            {
                DA = 0.10 * BasicSalary;
                HRA = 0.085 * BasicSalary;
                PF = 6200;
            }
            else if (Experience > 7)
            {
                DA = 0.07 * BasicSalary;
                HRA = 0.065 * BasicSalary;
                PF = 4100;
            }
            else if (Experience > 5)
            {
                DA = 0.041 * BasicSalary;
                HRA = 0.038 * BasicSalary;
                PF = 1800;
            }
            else
            {
                DA = 0.019 * BasicSalary;
                HRA = 0.02 * BasicSalary;
                PF = 1200;
            }

            NetSalary = BasicSalary + DA + HRA - PF;
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("(OnPayroll) Joining Date: " + JoiningDate + ", Experience: " + Experience + " years, Basic: rs." + BasicSalary);
            Console.WriteLine("DA: rs." + DA + ", HRA: rs." + HRA + ", PF: rs." + PF + ", Net Salary: rs." + NetSalary);
        }
    }
}
