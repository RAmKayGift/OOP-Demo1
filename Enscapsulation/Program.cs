using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int choice = 0;
            BankAccount account = new BankAccount("Fulufhelo", "2222");

            Console.WriteLine("Authentication");
            Console.Write("Enter the Pin : ");
            string pin = Console.ReadLine();

            if(account.ValidatePin(pin)) //execute this if pin is correct
            {
                Console.WriteLine("Correct PIN : " + account.ValidatePin("1234"));
                Console.WriteLine("Owner: " + account.Owner);
                Console.WriteLine("Balance: R" + account.Balance);
               

                while(choice != 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Menu \n1.Check Balance \n2.Deposit \n3.Withdraw \n4.Exit");
                    Console.Write("\tChoice : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    if (choice == 1)
                    {
                        Console.WriteLine("Balance: R" + account.Balance);
                    }
                    else if(choice == 2)
                    {
                        Console.Write("Enter doposit Amount : ");
                        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                        account.Deposit(depositAmount);
                        Console.WriteLine();
                    }
                    else if( choice == 3)
                    {
                        Console.Write("Enter withdrawal Amount : ");
                        decimal withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
                        account.Withdraw(withdrawalAmount);
                        Console.WriteLine();
                    }
                    else if(choice > 4) 
                    {
                        Console.WriteLine("Invalid Option");
                    }

                }

                Console.WriteLine("\tBye");
                

            }
            else
            {
                Console.WriteLine("Wrong Pin\n  Bye"); //run this if pin is not correct
            }

            

        }
    }
}
