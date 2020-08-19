using System;

namespace Arquitetura.DP.Creational
{
    public interface IVeiculo
    {
        void Limite(int limite);
    }

    public class Moto : IVeiculo
    {
        public void Limite(int limite)
        {
            Console.WriteLine("Limite de velocidade Moto: " + limite);
        }
    }

    public class Carro : IVeiculo
    {
        public void Limite(int limite)
        {
            Console.WriteLine("Limite de velocidade Carro: " + limite);
        }
    }

    public class Caminhonete : IVeiculo
    {
        public void Limite(int limite)
        {
            Console.WriteLine("Limite de velocidade Caminhonete: " + limite);
        }
    }


    public abstract class VeiculoFactory
    {
        public abstract IVeiculo ObterVeiculo(string categoria);
    }

    public class ConcreteVeiculoFactory : VeiculoFactory
    {
        public override IVeiculo ObterVeiculo(string categoria)
        {
            switch (categoria)
            {
                case "Pesado":
                    return new Caminhonete();
                case "Medio":
                    return new Carro();
                case "Leve":
                    return new Moto();
                default:
                    throw new ApplicationException(string.Format("Veiculo '{0}' não pode ser criado", categoria));
            }
        }
    }

    public class FactoryMethod
    {
        public static void Execucao()
        {
            var factory = new ConcreteVeiculoFactory();

            var moto = factory.ObterVeiculo("Leve");
            moto.Limite(300);

            var carro = factory.ObterVeiculo("Medio");
            carro.Limite(250);

            var caminhonete = factory.ObterVeiculo("Pesado");
            caminhonete.Limite(180);
        }
    }
}