using System;

namespace Arquitetura.DP.Structural
{
    public interface IBoleto
    {
        void ImprimirBoleto();
    }

    public class Boleto
    {
        private readonly IBoleto _boleto;

        public Boleto(IBoleto boleto)
        {
            _boleto = boleto;
        }

        public void ImprimirBoleto()
        {
            _boleto.ImprimirBoleto();
        }
    }

    public class MeuAdapter : BoletoPdf, IBoleto
    {
        public void ImprimirBoleto()
        {
            SalvarBoletoPDF();
        }
    }

    public class BoletoPdf
    {
        public void SalvarBoletoPDF()
        {
            Console.WriteLine("Boleto salvo em PDF");
        }
    }

    public class Adapter
    {
        public static void Execucao()
        {
            var adapter = new Boleto(new MeuAdapter());
            adapter.ImprimirBoleto();
        }
    }
}