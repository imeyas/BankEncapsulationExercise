using System;

namespace BankEncapsulationExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstAccount = new BankAccount(450.00);

            firstAccount.GetBalance();
            Console.WriteLine($"Your balance is: {firstAccount.Balance}\n");

            var secondAccount = new BankAccount();
            secondAccount.Deposit(450);
            Console.WriteLine($"Deposit accepted!\n");

            secondAccount.GetBalance();
            Console.WriteLine($"Second account balance is: {secondAccount.Balance}\n");
            
        }
    }
}