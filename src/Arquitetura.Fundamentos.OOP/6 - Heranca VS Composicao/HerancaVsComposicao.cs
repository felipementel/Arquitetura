namespace Arquitetura.Fundamentos.OOP
{
    //Herança
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }
    }

    // Composição no lugar de herança
    public class Cliente
    {
        private readonly Pessoa _pessoa;

        public Cliente(Pessoa pessoa)
        {
            _pessoa = pessoa;
        }
    }

    //Exemplo 2

    public interface IRepositorio<T>
    {
        void Adicionar(T objeto);

        void Excluir(T objeto);
    }

    public interface IRepositorioPessoa
    {
        void Adicionar(Pessoa objeto);
    }

    public class Repositorio<T> : IRepositorio<T>
    {
        public void Adicionar(T objeto)
        {
            // Código para atualizar
        }

        public void Excluir(T objeto)
        {
            // Código para excluir
        }
    }

    public class RepositorioHerancaPessoa : Repositorio<Pessoa>, IRepositorioPessoa
    {

    }

    public class RepositorioComposicaoPessoa : IRepositorioPessoa
    {

        private readonly IRepositorio<Pessoa> _repositorioPessoa;

        public RepositorioComposicaoPessoa(IRepositorio<Pessoa> repositorioPessoa)
        {
            _repositorioPessoa = repositorioPessoa;
        }

        public void Adicionar(Pessoa objeto)
        {
            _repositorioPessoa.Adicionar(objeto);
        }
    }

    public class TestesHerancaComposicao
    {
        public TestesHerancaComposicao()
        {
            var repoH = new RepositorioHerancaPessoa();
            repoH.Adicionar(new Pessoa());
            repoH.Excluir(new Pessoa());

            var repoC = new RepositorioComposicaoPessoa(new Repositorio<Pessoa>());
            repoC.Adicionar(new Pessoa());
        }
    }
}