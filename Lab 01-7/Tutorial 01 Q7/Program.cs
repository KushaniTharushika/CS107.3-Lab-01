using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_01_Q7
{
    class ATM
    {
        public static double balance = 1000;

        static void Main ()
        {
            bool continueTransaction = true;

            while (continueTransaction)
            {
                Console.WriteLine("\n Welcome to the ATM machine...");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an Option: ");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        CheckBalance();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        continueTransaction = false;
                        Console.WriteLine("Thank you for using ATM. Good Bye!");
                        break; 
                    default:
                        Console.WriteLine("Invaild Option. Please choose a valid option.");
                        break;
                }
            }
        }
        static void CheckBalance()
        {
            Console.WriteLine($"Your current balance is: ${balance}");
        }

        static void DepositMoney()
        {
                Console.Write("Enter the amount to deposit: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                if (amount > 0)
                {
                    balance += amount;
                    Console.WriteLine($"${amount} has been deposited successfully.");
                    Console.WriteLine($"Your updated balance is: ${balance}");
                }
                else
                {
                    Console.WriteLine("Invalid amount. Please enter a positive value.");
                }
        }

        static void WithdrawMoney()
        {
            Console.Write("Enter the amount to withdraw: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"${amount} has been withdrawn successfully.");
                Console.WriteLine($"Your updated balance is: ${balance}");
            }
            else if (amount <= 0)
            {
                Console.WriteLine("Invalid amount. Please enter a positive value.");
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
    }
    
}

