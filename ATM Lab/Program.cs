using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //username, password, account
            List<ATM> accounts = new List<ATM>
            {
                new ATM("brian", "ab1234", 100),
                new ATM("kyle", "america11", 500)
            };
            accounts = new List<string>();

            Console.WriteLine("Welcome to the Grand Circus ATM!");
            Console.WriteLine(" 1. Register \n 2. Login\n 3. Quit");

            string menuSelection = "";
            bool tryAgain = true;

            while (tryAgain)
            {
                string userInput = Console.ReadLine().ToLower();
                tryAgain = false;
                switch (userInput)
                {
                    case "1":
                    case "register":
                        menuSelection = "register";
                        break;

                    case "2":
                    case "login":
                        menuSelection = "login";
                        break;

                    case "3":
                    case "quit":
                        break;
                    default:
                        tryAgain = true;
                        Console.WriteLine("Invalid. Please enter a valid entry number from the menu.");
                        break;

                }
                
            }
            if (menuSelection == "1" || menuSelection == "register")
            {
                ATM.ListOutList(accounts);
                

                //ATM.GetUsername("Please create your username: ");
                //ATM.GetUserPassword("Please create your password: ");

                Console.WriteLine("Thank you for registering! Please select an option from the menu: ");
                Console.WriteLine(" 1. Login \n 2. Quit");
                menuSelection = "";
                string userInput = Console.ReadLine().ToLower();
                switch (userInput)
                {
                    case "1":
                    case "login":
                        menuSelection = "login";
                        break;

                    case "2":
                    case "quit":
                        menuSelection = "quit";
                        break;
                     
                }
            }    
            if (menuSelection == "1" || menuSelection == "login")
            {

            }

        }

        
    }
}
