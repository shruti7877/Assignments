namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pizza> pizzaList = new List<Pizza>
        {
            new Pizza("Small", 1, 1, 0),
            new Pizza("Medium", 2, 2, 1),
            new Pizza("Large", 3, 2, 2)
        };

            Console.WriteLine("*****Pizza Records:*******");

                foreach (Pizza pizza in pizzaList)
                {
                Console.WriteLine(pizza.GetDescription());
                }
            
        }
    }
}
