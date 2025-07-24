using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class OnContract:Employee
    {
        private string ContractDate;
        private int Duration; 
        private double Charges;

        public OnContract(int EmpID, string Name, string ReportingManager, string ContractDate, int Duration, double Charges)
           : base(EmpID, Name, ReportingManager)
        {
            this.ContractDate = ContractDate;
            this.Duration = Duration;
            this.Charges = Charges;
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("(OnContract) Date: " + ContractDate + ", Duration: " + Duration + " months, Charges: rs." + Charges);
        }
    }
}
