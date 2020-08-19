namespace Arquitetura.OOP
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

        private void ContratarServico()
        {

        }
    }
}