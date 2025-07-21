using System;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment3
{
    internal class Program
    {
            static List<Product> products = new List<Product>();
            static int Pcode = 1001;

            static void Main()
            {
                Console.Write("Enter Brand Name: ");
                Product.BrandName = Console.ReadLine();

                while (true)
                {
                    Console.WriteLine("1. Admin");
                    Console.WriteLine("2. Customer");
                    Console.WriteLine("3. Exit");
                    Console.Write("Enter choice: ");
                    int role = Byte.Parse(Console.ReadLine());

                    if (role == 1)
                        AdminMenu();
                    else if (role == 2)
                        CustomerMenu();
                    else
                        break;
                }
            }

        static void AdminMenu()
        {
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Show All Products");
            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
                AddProduct();
            else
            {
                foreach (var p in products)
                    p.Show();
            }
        }

            static void AddProduct()
            {
                Console.Write("Product Name: ");
                string Pname = Console.ReadLine();

                Console.Write("Stock Quantity: ");
                int Qty_in_Stock = int.Parse(Console.ReadLine());

                Console.Write("Discount (%): ");
                double Discount_Allowed = double.Parse(Console.ReadLine());
            Console.Write("Price per unit: ");
            double price = double.Parse(Console.ReadLine());

            Product p = new Product(Pcode++, Pname, Qty_in_Stock, Discount_Allowed,price);
                products.Add(p);
                Console.WriteLine("Product added.");
            }

        static void CustomerMenu()
        {
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();

            foreach (var p in products)
            {
                if (p.Pname.ToLower() == name.ToLower())
                {
                    Console.Write("Enter quantity: ");
                    int qty = int.Parse(Console.ReadLine());

                    if (qty <= p.Qty_in_Stock)
                    {
                        double total = p.CalculateAmount(qty);

                        
                        if (DateTime.Now.Day == 26 && DateTime.Now.Month == 1)
                        {
                            Console.WriteLine("Special 26th Jan offer! Additional 50% discount applied.");
                            total *= 0.5;
                        }

                            p.Qty_in_Stock -= qty;

                        Console.WriteLine("\nBILL");
                        Console.WriteLine("Product Code: " + p.Pcode);
                        Console.WriteLine("Product: " + p.Pname);
                        Console.WriteLine("Qty: " + qty);
                        Console.WriteLine("Total: Rs." + total);
                    }
                    else
                    {
                        Console.WriteLine("Not enough stock.");
                    }
                    return;
                }
            }

            Console.WriteLine("Product not found.");
        }
    }
}
