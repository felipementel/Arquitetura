namespace Arquitetura.DP.Creational
{
    public class ConexaoBancoDados
    {
        private static FactoryMethod2.GerenciadorConexao _gerenciador;

        public static FactoryMethod2.GerenciadorConexao Current
        {
            get
            {
                _gerenciador = _gerenciador ?? new FactoryMethod2.GerenciadorConexaoOracle();

                return _gerenciador;
            }
        }
    }
}