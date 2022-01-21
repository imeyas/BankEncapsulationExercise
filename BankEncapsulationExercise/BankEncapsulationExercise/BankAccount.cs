using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulationExercise
{
    public class BankAccount
    {

        public BankAccount()
        {

        }
        public BankAccount( double amountDeposited)
        {
                balance = amountDeposited;
        }
        private double balance = 0;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(double amountDeposited)
        {
            balance += amountDeposited;
        }


        public double GetBalance()
        {
            return balance;
        }
    }
}
