namespace Arquitetura.Fundamentos.SOLID.ISP.Solucao.Interfaces
{
    public interface ICadastroCliente
    {
        void ValidarDados();
        void SalvarBanco();
        void EnviarEmail();
    }
}