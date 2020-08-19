using System;
using Arquitetura.DP.Behavioral;
using Arquitetura.DP.Creational;
using Arquitetura.DP.Structural;

namespace Arquitetura.DP
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("Escolha a operação");
            Console.WriteLine("------------------------");
            Console.WriteLine("Creational Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("1 - Factory");
            Console.WriteLine("2 - Abstract Factory");
            Console.WriteLine("3 - Singleton");
            Console.WriteLine("------------------------");
            Console.WriteLine("Structural Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("4 - Adapter");
            Console.WriteLine("5 - Facade");
            Console.WriteLine("------------------------");
            Console.WriteLine("Behavioral Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("6 - Command");
            Console.WriteLine("7 - Observer");
            Console.WriteLine("8 - Strategy");

            var opcao = Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("");

            switch (opcao.KeyChar)
            {
                case '1':
                    FactoryMethod.Execucao();
                    break;
                case '2':
                    AbstractFactory.Execucao();
                    break;
                case '3':
                    Singleton.Execucao();
                    break;
                case '4':
                    Adapter.Execucao();
                    break;
                case '5':
                    Facade.Execucao();
                    break;
                case '6':
                    Command.Execucao();
                    break;
                case '7':
                    Observer.Execucao();
                    break;
                case '8':
                    Strategy.Execucao();
                    break;
            }

            Console.ReadKey();
        }
    }
}
