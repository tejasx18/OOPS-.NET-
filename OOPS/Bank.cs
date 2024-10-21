using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Bank
    {
        private double balance;

        public Bank()
        {
            
        }
        public Bank(double b)
        {
           balance = b; 
        }

        public void Deposit(double amount)
        {   
            balance += amount;
        }
        public string Withdraw(double amount) {
            if (balance < amount) {
                return "Insufficient Balance";
            }
            balance -= amount;
            return "Withdrawn successfully";
        }

        public double GetBalance() { 
            return balance;
        }

    }
}
