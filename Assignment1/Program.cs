using System.ComponentModel;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice=0;
            while (choice != 11)
            {

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
                Console.WriteLine("11 Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("hello!!");
                        break;
                    case 2:
                        int n1, n2;
                        Console.WriteLine("enter two nos.");
                        n1 = Convert.ToByte(Console.ReadLine());
                        n2 = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine("addition" + (n1 + n2));
                        Console.WriteLine("subtraction" + (n1 - n2));
                        Console.WriteLine("Product" + (n1 * n2));
                        Console.WriteLine("Quotient" + (n1 / n2));
                        Console.WriteLine("Remainder" + (n1 % n2));
                        break;
                    case 3:
                        int x, y;
                        Console.WriteLine("enter two nos.");
                        x = Convert.ToInt16(Console.ReadLine());
                        y = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("enter operations (+,-,*,/,%: ");
                        char op = Convert.ToChar(Console.ReadLine());
                        switch (op)
                        {
                            case '+':
                                Console.WriteLine("add" + (x + y));
                                break;
                            case '-':
                                Console.WriteLine("sub" + (x - y));
                                break;
                            case '*':
                                Console.WriteLine("pro" + (x * y));
                                break;
                            case '/':
                                Console.WriteLine("div" + (x / y));
                                break;
                            case '%':
                                Console.WriteLine("rem" + (x % y));
                                break;
                            default:
                                Console.WriteLine("Invalid Choice");
                                break;
                        }
                        break;

                    case 4:
                        for (int i = 1; i <= 10; i++)
                            Console.WriteLine("my name is Shruti");
                        break;
                    case 5:
                        int n;
                        n = Convert.ToInt16(Console.ReadLine());
                        for (int i = 0; i <= n; i += 2)
                            Console.WriteLine(i);
                        int j = 0;
                        while (j <= n)
                        {
                            Console.WriteLine(j);
                            j += 2;
                        }
                        int k = 0;
                        do
                        {
                            Console.WriteLine(k);
                            k += 2;
                        } while (k <= n);

                        break;
                    case 6:

                        int num = Convert.ToInt16(Console.ReadLine());
                        for (int i = 1; i <= num; i += 2)
                            Console.WriteLine(i);
                        j = 1;
                        while (j <= num)
                        {
                            Console.WriteLine(j);
                            j += 2;
                        }
                        k = 1;
                        do
                        {
                            Console.WriteLine(k);
                            k += 2;
                        } while (k <= num);

                        break;
                    case 7:
                        int a= Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= 10; i++)
                            Console.WriteLine(a + "*" + i + "=" + (a * i));
                        break;
                    case 8:
                        int p = 100;
                        while (p >= 5)
                        {
                            Console.WriteLine(p + " ");
                            p -= 3;
                        }
                        break;
                    case 9:
                        int x1 = 4;
                        int y1 = 5;
                        Console.Write(x1);
                        Console.Write(y1);
                        break;
                    case 10:
                        int x2 = 4;
                       int y2 = 5;
                        Console.WriteLine(x2);
                        Console.WriteLine(y2);
                        break;
                    case 11:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
        
           
       
