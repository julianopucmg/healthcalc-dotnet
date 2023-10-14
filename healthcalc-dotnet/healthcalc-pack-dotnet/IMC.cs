using healthcalc_pack_dotnet.Interfaces;

namespace healthcalc_pack_dotnet
{
    public class IMC : IIMC
    {
        public double CalcularIMC(double Peso, double Altura)
        {

            return Math.Round( Peso / (Altura * Altura),2);
        }

        public double RetornarCAssificacaoIMC(double IMC)
        {
            throw new NotImplementedException();
        }
    }
}