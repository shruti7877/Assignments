using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Pizza
    {
         private string Size { get; set; }
         int CheeseToppings { get; set; }
         int PepperoniToppings { get; set; }
         int HamToppings { get; set; }

        public Pizza(string size, int cheeseToppings, int pepperoniToppings, int hamToppings)
        {
            this.Size = size;
            this.CheeseToppings = cheeseToppings;
            this.PepperoniToppings = pepperoniToppings;
            this.HamToppings = hamToppings;
        }
        
       
        public double CalcCost()
        {
            int totalToppings = CheeseToppings + PepperoniToppings + HamToppings;
            double baseCost=0;

            switch (Size.ToLower())
            {
                case "small":
                    baseCost = 10;
                    break;
                case "medium":
                    baseCost = 12;
                    break;
                case "large":
                    baseCost = 14;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            return baseCost + (2 * totalToppings);
        }
        public string GetDescription()
        {
            return "Size: " + Size + ", Cheese Toppings: " + CheeseToppings +", Pepperoni Toppings: " + PepperoniToppings + ", Ham Toppings: " + HamToppings +", Total Cost: $" + CalcCost();
        }



    }
}
