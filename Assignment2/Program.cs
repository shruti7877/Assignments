namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter marks in Mathematics: ");
            int math = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks in Physics: ");
            int phy = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks in Chemistry: ");
            int chem = Convert.ToInt32(Console.ReadLine());

            int total = math + phy + chem;

            if ((math >= 65 && phy >= 55 && chem >= 50 && total >= 180) || (math + phy >= 140))
                Console.WriteLine("The candidate is eligible for admission.");

            else

                Console.WriteLine("The candidate is NOT eligible for admission.");

        }
        }

    }
