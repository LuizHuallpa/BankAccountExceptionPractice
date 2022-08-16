using System;
using BankAccountExceptionPractice.Entities;
using BankAccountExceptionPractice.Entities.Exceptions;
namespace BankAccountExceptionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double limit = double.Parse(Console.ReadLine());
                Account account = new Account(number, holder, balance, limit);
                Console.WriteLine();

                Console.Write("Enter the amount to withdraw:");
                double withdraw = double.Parse(Console.ReadLine());
                account.Withdraw(withdraw);
                Console.WriteLine($"New balance {account.Balance:F2}");

            }

            catch (DomainExceptions e)
            {
                Console.WriteLine($"{e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Format error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error {e.Message}");
            }


        }
    }
}

