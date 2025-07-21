namespace Assignment4
{
    internal class Program
    {

        static List<Product1> products = new List<Product1>();

        static void Main()
        {
            // Adding 5 products with user-input price
            products.Add(new Product1(1001, "Coffee", 10, 0.2, GetPrice("Coffee")));
            products.Add(new Product1(1002, "Instant Coffee", 50, 0.1, GetPrice("Instant Coffee")));
            products.Add(new Product1(1003, "Chocolate", 30, 0.15, GetPrice("Chocolate")));
            products.Add(new Product1(1004, "Cold Coffee", 20, 0.25, GetPrice("Cold Coffee")));
            products.Add(new Product1(1005, "Green Tea", 40, 0.1, GetPrice("Green Tea")));

            Console.WriteLine("\nProduct List:");
            foreach (Product1 p in products)
            {
                p.Display();
            }

            Console.WriteLine("\nCustomer Purchase Section:");
            Console.Write("Enter product name: ");
            string pname = Console.ReadLine();

            Product1 found = products.Find(p => p.Pname.Equals(pname, StringComparison.OrdinalIgnoreCase));

            if (found != null)
            {
                Console.Write("Enter quantity to purchase: ");
                int quantityToBuy = Convert.ToInt32(Console.ReadLine());

                if (quantityToBuy <= found.QtyInStock)
                {
                    double total = found.Price * quantityToBuy;
                    double discount = total * Product1.DISCOUNT;
                    double finalAmount = total - discount;

                    Console.WriteLine("\n********** Bill **********");
                    Console.WriteLine("Product Name: " + found.Pname);
                    Console.WriteLine("Quantity: " + quantityToBuy);
                    Console.WriteLine("Unit Price: rs." + found.Price);
                    Console.WriteLine("Total Amount: rs." + total);
                    Console.WriteLine("Discount (50%): rs." + discount);
                    Console.WriteLine("Amount to Pay: rs." + finalAmount);
                }
                else
                {
                    Console.WriteLine("Sorry, not enough stock available.");
                }
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        static double GetPrice(string productName)
        {
            Console.Write("Enter price for " + productName + ": rs.");
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}

