namespace Arquitetura.DP.Behavioral
{
    public abstract class Observador
    {

        public void Notificar()
        {

        }

    }


    public class Observado
    {
        private readonly Observador _observador;

        public Observado(Observador observador)
        {
            _observador = observador;
        }

        public void Acao()
        {
            _observador.Notificar();
        }
    }
}