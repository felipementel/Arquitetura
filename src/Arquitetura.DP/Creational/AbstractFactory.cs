using System;

namespace Arquitetura.DP.Creational
{
    internal abstract class ContinenteFactory
    {
        public abstract Herbivoro ObterHerbivoro();
        public abstract Carnivoro ObterCarnivoro();
    }

    internal class AfricaFactory : ContinenteFactory
    {
        public override Herbivoro ObterHerbivoro()
        {
            return new Gazela();
        }
        public override Carnivoro ObterCarnivoro()
        {
            return new Leao();
        }
    }

    internal class AmericaFactory : ContinenteFactory
    {
        public override Herbivoro ObterHerbivoro()
        {
            return new Coelho();
        }
        public override Carnivoro ObterCarnivoro()
        {
            return new Lobo();
        }
    }

    internal abstract class Herbivoro
    {
    }

    internal abstract class Carnivoro
    {
        public abstract void Devorar(Herbivoro h);
    }

    internal class Coelho : Herbivoro
    {
    }

    internal class Leao : Carnivoro
    {
        public override void Devorar(Herbivoro h)
        {
            // Devorar Gazela
            Console.WriteLine(GetType().Name +
              " devora " + h.GetType().Name);
        }
    }

    internal class Gazela : Herbivoro
    {
    }

    internal class Lobo : Carnivoro
    {
        public override void Devorar(Herbivoro h)
        {
            Console.WriteLine(GetType().Name +
              " devora " + h.GetType().Name);
        }
    }

    internal class Animais
    {
        private readonly Herbivoro _herbivoro;
        private readonly Carnivoro _carnivoro;

        public Animais(ContinenteFactory factory)
        {
            _carnivoro = factory.ObterCarnivoro();
            _herbivoro = factory.ObterHerbivoro();
        }

        public void CacarComida()
        {
            _carnivoro.Devorar(_herbivoro);
        }
    }

    public class AbstractFactory
    {
        public static void Execucao()
        {
            ContinenteFactory africa = new AfricaFactory();
            var animais = new Animais(africa);
            animais.CacarComida();

            ContinenteFactory america = new AmericaFactory();
            animais = new Animais(america);
            animais.CacarComida();
        }
    }
}