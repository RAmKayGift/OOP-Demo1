using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation

{
    internal class BankAccount
    {
       

        // the wner can be read outside, but only set inside constructor
        public string Owner { get; }

        // Balance can be read outside but cannot be directly changed outside
        public decimal Balance { get; private set; }

        
        private string pin;

        // Constructor
        public BankAccount(string owner, string accountPin)
        {
            Owner = owner;
            pin = accountPin;
            Balance = 0;
        }

        // Checks if the entered pin is correct
        public bool ValidatePin(string input)
        {
            return input == pin;
        }

        // Deposit money
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Invalid Deposit");
            }

            Balance = Balance + amount;
            Console.WriteLine("Deposit Successful");
            
        }

        // Withdraw money
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Invalid Withdrawal");
            }

            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient Funds.");
            }

            Balance = Balance - amount;
            Console.WriteLine("Withrawal Successful");
        }
    }
}
