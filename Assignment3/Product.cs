using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Product
    {
        public static string BrandName;
        public const double DISCOUNT = 0.5;
            public int Pcode;

            public string Pname;
            public int Qty_in_Stock;
            public double Discount_Allowed;
            public double Price;



        public Product(int code, string name, int stock, double discount,double price)
            {
                Pcode = code;
                Pname = name;
                Qty_in_Stock = stock;
                Discount_Allowed = discount;
                Price = price;
            }

            public void Show()
            {
                Console.WriteLine("Code: " + Pcode);
                Console.WriteLine("Name: " + Pname);
                Console.WriteLine("Stock: " + Qty_in_Stock);
                Console.WriteLine("Price: Rs." +Price);
                Console.WriteLine("Allowed Discount: " + Discount_Allowed + "%");
                Console.WriteLine("Brand: " + BrandName);
            }

            public double CalculateAmount(int qty)
            {
            double total = Price * qty;
            return total * (1 - Discount_Allowed / 100.0);
        }

    }
}
