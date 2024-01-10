using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnOrderApp
{
    class Home
    {
        public CallingMethods _callingMethods;
        public Home()
        {
            UserAccount userAccount = new UserAccount();
            _callingMethods = new CallingMethods(userAccount);
        }
        public void homePage()
        {

            while (true)
            {
                Console.WriteLine("Welcome to DELI Online Shopping");
                Console.WriteLine();
                Console.WriteLine("1. About");
                Console.WriteLine("2. Account");
                Console.WriteLine("3. Cart");
                Console.WriteLine("4. Help");
                Console.WriteLine("0. Exit");
                Console.WriteLine('\n');

                Console.Write("Enter your choice: ");
                string? choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        Console.WriteLine("About Page");
                        About about = new About(); //calling the about page and instantiating it
                        about.aboutWebsite();
                        break;
                    case "2":
                        Console.WriteLine("Account Page");
                        _callingMethods.AccountFunctions();
                        break;
                    case "3":
                        Console.WriteLine("Cart Page");
                        /*CallMethods callmethods = new CallMethods();*/ //calling the cart page and instantiating it
                        break;
                    case "4":
                        Console.WriteLine("Help Page");
                        HelpMessages helpMessages = new HelpMessages(); //calling the help page and instantiating it to display the help messages
                        helpMessages.displayHelpMessages(); 
                        break;
                    case "0":
                        Console.WriteLine("Thank you for using DELI Online Shopping. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }
    }
}
