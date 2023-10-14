namespace healthcalc_pack_dotnet.Interfaces
{
    public interface IIMC
    {
        public double CalcularIMC(double Peso, double Altura);
        public double RetornarCAssificacaoIMC(double IMC);

    }
}
