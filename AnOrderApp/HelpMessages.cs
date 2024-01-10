using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnOrderApp
{
    class HelpMessages
    {
        public void displayHelpMessages()
        {
            Console.WriteLine("Help Menu:");
            Console.WriteLine("1. Place an order.");
            Console.WriteLine("2. Track your order.");
            Console.WriteLine("3. Order Cancellation.");
            Console.WriteLine("4. Returns and Refunds.");
            Console.WriteLine("5. Payment.");

            Console.Write("Enter the number of the help message you want: ");
            string? userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Place an order. Select the food item you want from the menu. It will be automatically added to the cart.");
                    break;
                case "2":
                    Console.WriteLine("Track your order. Click on the cart icon and see the food item you selected.");
                    break;
                case "3":
                    Console.WriteLine("Order Cancellation. Click on the cart icon and select the delete order button.");
                    break;
                case "4":
                    Console.WriteLine("Returns and Refunds. We advise customers to be sure of their order before requesting it. But in case, reach us using this number: 011233445566.");
                    break;
                case "5":
                    Console.WriteLine("Payment. After placing it in the cart, you can make payments on the shop page.");
                    break;
                default:
                    Console.WriteLine("Invalid help message number. Please try again.");
                    break;
            }
        }
    }
}
