////John Pietrangelo 9am CIS340
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnPietrangelo4BankWithdrawl
{
    class Program
    {
        static void Main(string[] args)
        {
            double checkingAccount = 10000; 
            double moneyMarketAccount = 80085;
            double savingsAccount = 11000;
            
            string accountSeletion = "";
            double withdrawlAmount;
            bool runReciept = true;
           
            Console.WriteLine("\tWelocome to ABC Bank\n");
            Console.WriteLine("Select an account for your withdrawl\n");
            Console.WriteLine("1 - Checking");
            Console.WriteLine("2 - MoneyMarket");
            Console.WriteLine("3 - Savings\n");
            Console.Write("Enter your selection: ");

            //Get users selection
            accountSeletion = Console.ReadLine();

            //Ask for withdrawl ammount
            Console.WriteLine();
           

            //Switch statement to select account type
            switch (accountSeletion)
            {
                case "1":
                    Console.WriteLine("Current Checking Balance: \t{0:C}", checkingAccount);
                    break;
                case "2":
                    Console.WriteLine("Current Balance: \t{0:C}", moneyMarketAccount);
                    break;
                case "3":
                    Console.WriteLine("Current Balance: \t{0:C}", savingsAccount);
                    break;
                default:
                    runReciept = false;
                    break;
            }

            Console.Write("Enter the amount you would like to withdral - Use Format: < 0.00 > ");
            withdrawlAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            //Switch statement to withdrawl funds from selected account
            switch (accountSeletion)
            {
                case "1":
                    checkingAccount -= withdrawlAmount;
                    break;
                case "2":
                    moneyMarketAccount -= withdrawlAmount;
                    break;
                case "3":
                    savingsAccount -= withdrawlAmount;
                    break;

                //Displays Error Message
                default:
                    Console.WriteLine("******************************************************");
                    Console.WriteLine();
                    Console.WriteLine("\t***Invalad Account Selection***");
                    break;
            }
           
            //Get reciept selection
            //Decide to display reciept, success 
            if (runReciept)
            {
                Console.WriteLine();
                Console.Write("Do you want a reciept? Y = Yes or N = No:   ");

                if (Console.ReadLine().ToLower() == "y")
                {
                    Console.WriteLine();
                    Console.WriteLine("******************************************************");
                    Console.WriteLine();
                    Console.WriteLine("\t    Your new Balances are:\n\nChecking Account Balance: \t{0,10:C}\n" + 
                                      "Money Market Balance: \t\t{1,10:C}\n" + "Savings Account Balance: \t{2,10:C}", 
                                       checkingAccount, moneyMarketAccount, savingsAccount);
                }

                else
                {
                    Console.WriteLine(); 
                    Console.WriteLine("******************************************************");
                    Console.WriteLine();
                    Console.WriteLine("WITHDRAWL SUCCESSFUL");
                }
            }
            
            //Pause display
            Console.ReadLine();



        }
    }
}
