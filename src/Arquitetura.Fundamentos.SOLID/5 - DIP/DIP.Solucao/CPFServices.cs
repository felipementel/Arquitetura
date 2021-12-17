using Arquitetura.Fundamentos.SOLID.DIP.Solucao.Interfaces;

namespace Arquitetura.Fundamentos.SOLID.DIP.Solucao
{
    public class CPFServices : ICPFServices
    {
        public bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}