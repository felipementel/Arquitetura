namespace Arquitetura.DP.Creational
{
    public class FactoryMethod2
    {
        public abstract class GerenciadorConexao
        {
            public abstract Conexao ObterConexao();
        }

        public abstract class Conexao
        {

        }

        public class GerenciadorConexaoOracle : GerenciadorConexao
        {
            public override Conexao ObterConexao()
            {
                return new ConexaoOracle();
            }
        }

        public class ConexaoOracle : Conexao
        {

        }

        public class GerenciadorConexaoSQL : GerenciadorConexao
        {
            public override Conexao ObterConexao()
            {
                return new ConexaoSQL();
            }
        }

        public class ConexaoSQL : Conexao
        {

        } 
    }
}