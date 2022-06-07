using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount johnsAccount = new BankAccount();
            Console.WriteLine("How much would you like to deposit");
            var amountToDeposit = double.Parse(Console.ReadLine());

            johnsAccount.Deposit(amountToDeposit);
            Console.WriteLine($"Thank you! Your balance is now {johnsAccount.GetBalance()}.");

            Console.WriteLine("How much would you like to Withdraw?");
            var amountToWithdraw = double.Parse(Console.ReadLine());

            johnsAccount.Withdraw(amountToWithdraw);
            Console.WriteLine($"Thank you! Your balance is now {johnsAccount.GetBalance()}.");
        }
    }
}
