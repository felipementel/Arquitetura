using System;

namespace Arquitetura.DP.Behavioral
{
    public class Command2
    {
        private class ServicoNota
        {
            public void GerarNota(CriacaoNovaNotaCommand comand)
            {

            }
        }

        class CriacaoNovaNotaCommand
        {
            public int Numero { get; set; }
            public int IdCliente { get; set; }

            public DateTime DataCriacao { get; set; }
        } 
    }
}