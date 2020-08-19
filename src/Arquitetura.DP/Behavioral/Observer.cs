using System;
using System.Collections.Generic;

namespace Arquitetura.DP.Behavioral
{
    public interface IInvestor
    {
        void Update(Stock stock);
    }

    public abstract class Stock
    {
        private double _price;
        private readonly List<IInvestor> _investors = new List<IInvestor>();

        protected Stock(string symbol, double price)
        {
            Symbol = symbol;
            _price = price;
        }

        public void Attach(IInvestor investor)
        {
            _investors.Add(investor);
        }

        public void Detach(IInvestor investor)
        {
            _investors.Remove(investor);
        }

        private void Notify()
        {
            foreach (var investor in _investors)
            {
                investor.Update(this);
            }

            Console.WriteLine("");
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }

        public string Symbol { get; private set; }
    }

    internal class IBM : Stock
    {
        public IBM(string symbol, double price)
            : base(symbol, price)
        {
        }
    }

    internal class Investor : IInvestor
    {
        private readonly string _name;

        public Investor(string name)
        {
            _name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine("Notificando {0} que {1} " +
              "teve preço alterado para {2:C}", _name, stock.Symbol, stock.Price);
        }

        public Stock Stock { get; set; }
    }

    public class Observer
    {
        public static void Execucao()
        {
            var ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("João"));
            ibm.Attach(new Investor("Maria"));

            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;
        }
    }
}