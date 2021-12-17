using Arquitetura.Fundamentos.DI.Base.Interfaces;

namespace Arquitetura.Fundamentos.DI.Base
{
    public class SMS : IMensagem
    {
        public void Enviar()
        {
            // Enviar SMS
        }

        public void Validar()
        {
            // Validar Mensagem
        }
    }
}