namespace Arquitetura.OOP
{
    public interface IRepositorio
    {
        void Adicionar();
    }

    public class Repositorio : IRepositorio
    {
        public void Adicionar()
        {
            // Adiciona item
        }
    }

    public class Implementacao
    {
        public void Processo()
        {
            var repositorio = new Repositorio();
            repositorio.Adicionar();
        }
    }

    public class Abstracao
    {
        private readonly IRepositorio _repositorio;

        public Abstracao(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Processo()
        {
            _repositorio.Adicionar();
        }
    }
}