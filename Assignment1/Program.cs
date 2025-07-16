using System.ComponentModel;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("1.Display Hello Message");
                Console.WriteLine("2.Display Result of Addition ,Subtraction ,Product,Quotient of two nos.");
                Console.WriteLine("3.Display Result of Addition ,Subtraction ,Product,Quotient of two nos.depending upon choice");
                Console.WriteLine("4.Display your name");
                Console.WriteLine("5.Display all even nos.  by using do while ,while,for loop");
                Console.WriteLine("6.Display all odd nos.  by using do while ,while,for loop");
                Console.WriteLine("7.Display table of a number using all loops");
                Console.WriteLine("8.Display numbers from 100 to 5 with a gap of 3");
                Console.WriteLine("9.Declare some int variables ,assign values and display in one line");
                Console.WriteLine("10.Declare some int variables ,assign values and display in separate line");
                Console.WriteLine("enter your choice: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        DisplayMsg();
                        break;
                    case "2":
                        PerformArithmetic();
                        break;
                    case "3":
                        PerformChoiceArithmetic();
                        break;
                    case "4":
                        DisplayName();
                        break;
                    case "5":
                        DisplayNametenTimes();
                        break;
                    case "6":
                        EvenNos();
                        break;
                    case "7":
                        OddNos();
                        break;
                    case "8":
                        DisplayGap();
                        break;
                    case "9":
                        DisplayOneLine();
                        break;
                    case "10":
                        DisplaySeparateLine();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
        static void DisplayMsg() {
            Console.WriteLine("Hello World");
        }
        static void PerformArithmetic() {
            Console.WriteLine("enter first num");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter second num");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Add:{n1 + n2}");
            Console.WriteLine($"Sub:{n1 - n2}");
            Console.WriteLine($"Pro: {n1 * n2}");
            Console.WriteLine($"Quo: {n1 / n2}");
            Console.WriteLine($"Rem: {n1 % n2}");
        }
        static void PerformChoiceArithmetic() {
            Console.WriteLine("choose operation");
            Console.WriteLine("enter first num");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter second num");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Sub");
            Console.WriteLine("3.Pro");
            Console.WriteLine("4.Quo");
            string ch = Console.ReadLine();
            switch (ch)
            {
                case "1":
                    Console.WriteLine($"Addition:{num1 + num2}");
                    break;
                case "2":
                    Console.WriteLine($"Subtraction:{num1 - num2}");
                    break;
                case "3":
                    Console.WriteLine($"Product:{num1 * num2}");
                    break;
                case "4":
                    Console.WriteLine($"Quotient:{num1 / num2}");
                    break;
                case "5":
                    Console.WriteLine($"Remainder:{num1 % num2}");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
        static void DisplayName()
        {
            Console.WriteLine("my name is shruti");

        }
        static void DisplayNametenTimes()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("My name is shruti");
            }
        }
        static void EvenNos()
        {
            Console.WriteLine("enter upper limit");
            int limit = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= limit; i += 2)
                Console.WriteLine($"{i}");
            Console.WriteLine("while loops");
            int j = 0;
            while (j < limit)
            {
                Console.WriteLine($"{j}");
                j += 2;
            }
            Console.WriteLine("do while");
            int k = 0;
            do
            {
                Console.WriteLine($"{k}");
                k += 2;
            } while (k <= limit);
        }
        static void OddNos()
        {
            Console.WriteLine("enter upper limit");
            int limit = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= limit; i += 2)
                Console.WriteLine($"{i}");
            Console.WriteLine("while loops");
            int j = 1;
            while (j <=limit)
            {
                Console.WriteLine($"{j}");
                j += 2;
            }
            Console.WriteLine("do while");
            int k = 1;
            do
            {
                Console.WriteLine($"{k}");
                k += 2;
            } while (k <= limit);
        }
        static void DisplayGap()
        {
            for (int i = 100; i >= 5; i -= 3)
            {
                Console.WriteLine($"{i}");
            }
        }
        static void DisplayOneLine()
        {
            int n1 = 4;
            int n2 = 5;
            Console.Write(n1);
            Console.Write(n2);
        }
        static void DisplaySeparateLine()
        {
            int n1 = 4;
            int n2 = 5;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
        }

    }
}
