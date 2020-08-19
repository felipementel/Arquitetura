using System;

namespace Arquitetura.DP.Structural
{
    internal class Bank
    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Console.WriteLine("Validar conta de: " + c.Name);
            return true;
        }
    }

    internal class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine("Validar crédito para: " + c.Name);
            return true;
        }
    }

    internal class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Verificar emprestimos para: " + c.Name);
            return true;
        }
    }

    internal class Customer
    {
        public Customer(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }

    internal class Mortgage
    {
        private readonly Bank _bank = new Bank();
        private readonly Loan _loan = new Loan();
        private readonly Credit _credit = new Credit();

        public bool IsEligible(Customer cust, int amount)
        {
            Console.WriteLine("{0} aprovado para empréstimo de: {1:C} \n",cust.Name, amount);

            var eligible = true;

            // Verifique credibilidade do requerente
            if (!_bank.HasSufficientSavings(cust, amount))
            {
                eligible = false;
            }
            else if (!_loan.HasNoBadLoans(cust))
            {
                eligible = false;
            }
            else if (!_credit.HasGoodCredit(cust))
            {
                eligible = false;
            }

            return eligible;
        }
    }

    public class Facade
    {
        public static void Execucao()
        {
            // Facade
            var mortgage = new Mortgage();

            // Avaliar a elegibilidade de empréstimo para o cliente
            var customer = new Customer("João da Silva");
            var eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("\n" + customer.Name +" foi " + (eligible ? "Aprovado" : "Rejeitado"));
        }
    }
}