namespace Arquitetura.DP.Creational
{
    public abstract class NotaFiscalEletronica
    {

    }

    public class NFeV2 : NotaFiscalEletronica
    {

    }

    public class NFeV3 : NotaFiscalEletronica
    {

    }

    public abstract class ConhecimentoTransporteEletronico
    {

    }

    public class CTeV2 : ConhecimentoTransporteEletronico
    {

    }

    public class CTeV3 : ConhecimentoTransporteEletronico
    {

    }

    public abstract class FabricaDocumentoFiscalEletronico
    {
        public abstract NotaFiscalEletronica GerarNota();
        public abstract ConhecimentoTransporteEletronico GerarConhecimentoTransporte();
    }

    public class FabricaDFeV2 : FabricaDocumentoFiscalEletronico
    {
        public override ConhecimentoTransporteEletronico GerarConhecimentoTransporte()
        {
            return new CTeV2();
        }

        public override NotaFiscalEletronica GerarNota()
        {
            return new NFeV2();
        }
    }

    public class FabricaDFeV3 : FabricaDocumentoFiscalEletronico
    {
        public override ConhecimentoTransporteEletronico GerarConhecimentoTransporte()
        {
            return new CTeV3();
        }

        public override NotaFiscalEletronica GerarNota()
        {
            return new NFeV3();
        }
    }
}