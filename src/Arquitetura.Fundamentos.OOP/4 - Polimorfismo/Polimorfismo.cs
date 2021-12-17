namespace Arquitetura.Fundamentos.OOP
{
    public class CafeteiraEspressa : Eletrodomestico
    {
        public CafeteiraEspressa(string nome, int voltagem)
            : base(nome, voltagem)
        {

        }

        public CafeteiraEspressa()
            : base("Padrao", 220)
        {

        }

        private static void AquecerAgua()
        {

        }

        private static void MoerGraos()
        {

        }

        public void FazerCafe()
        {
            AquecerAgua();
            MoerGraos();
            // ETC...
        }

        public override void Ligar()
        {
            // Verificar recipiente de agua
        }

        public override void Desligar()
        {
            // Resfriar aquecedor
        }
    }
}