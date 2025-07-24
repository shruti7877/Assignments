using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Employee
    {
        private int EmpID;
        private string Name;
        private string ReportingManager;

        public Employee(int EmpID, string Name, string ReportingManager)
        {
            this.EmpID = EmpID;
            this.Name = Name;
            this.ReportingManager = ReportingManager;
        }
        public virtual void DisplayDetails()
        {
            Console.WriteLine("ID: " + EmpID + ", Name: " + Name + ", Manager: " + ReportingManager);
        }

    }
}
