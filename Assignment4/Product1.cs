using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Product1
    {
        public static string BrandName = "BRU";   
        public const double DISCOUNT = 0.5;             // 50% discount

        public int Pcode { get; set; }
        public string Pname { get; set; }
        public int QtyInStock { get; set; }
        public double DiscountAllowed { get; set; }
        public double Price { get; set; }              

        public Product1(int code, string name, int stock, double discount, double price)
        {
            Pcode = code;
            Pname = name;
            QtyInStock = stock;
            DiscountAllowed = discount;
            Price = price;
        }
        public void Display()
        {
            Console.WriteLine("Code: " + Pcode);
            Console.WriteLine("Name: " + Pname);
            Console.WriteLine("Stock: " + QtyInStock );
            Console.WriteLine("Discount Allowed: " + (DiscountAllowed * 100) + "%");
            Console.WriteLine(" Price: rs." + Price);
            Console.WriteLine(" Brand: " + BrandName);
        }
    }
}