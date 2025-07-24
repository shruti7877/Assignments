using System.Diagnostics.Contracts;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            string choice;

            do
            {
                Console.WriteLine("\nEnter Employee Type (1 - OnContract, 2 - OnPayroll): ");
                int type = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter ID: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Reporting Manager: ");
                string manager = Console.ReadLine();

                if (type == 1)
                {
                    Console.Write("Enter Contract Date: ");
                    string cdate = Console.ReadLine();
                    Console.Write("Enter Duration (months): ");
                    int duration = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Charges: ");
                    double charges = Convert.ToDouble(Console.ReadLine());

                    OnContract emp = new OnContract(id, name, manager, cdate, duration, charges);
                    employees.Add(emp);
                }
                else if (type == 2)
                {
                    Console.Write("Enter Joining Date: ");
                    string jdate = Console.ReadLine();
                    Console.Write("Enter Experience (years): ");
                    int exp = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Basic Salary: ");
                    double basic = Convert.ToDouble(Console.ReadLine());
                    OnPayroll payrollEmp = new OnPayroll(id, name, manager, jdate, exp, basic);
                    employees.Add(payrollEmp);
                }

                Console.Write("Do you want to enter another employee? (yes/no): ");
                choice = Console.ReadLine().ToLower();

            } while (choice == "yes");

            Console.WriteLine("\n***** Employee Details *******\n");
            foreach (Employee emp in employees)
            {
                emp.DisplayDetails();
            }

            Console.WriteLine("Total Employees Entered: " + employees.Count);
        }
    }
}
