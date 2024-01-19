using DesafioTratamentoExcessoes.Entities;
using DesafioTratamentoExcessoes.Entities.Exeption;
using System.Diagnostics.Metrics;
using System.Globalization;

namespace DesafioTratamentoExcessoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double intialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account c1 = new Account(number, holder, intialBalance, withdrawLimit);
            
            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                c1.Withdraw(amount);
                Console.WriteLine("New balance: " + c1.Balance.ToString("F2"), CultureInfo.InvariantCulture);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw issue: " + e.Message);
            }
        }
    }
}