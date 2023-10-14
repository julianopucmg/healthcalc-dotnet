using healthcalc_pack_dotnet;
using healthcalc_pack_dotnet.Interfaces;

namespace healthcalc_test_dotnet.Pack
{
    public class IMCTest
    {
        [Fact]
        public void CalculaIMC_QuandoPesoEAlturaValidos_EntaoRetornaIndice()
        {
            // Arrange
            IIMC imc = new IMC();
            double Peso = 85 ;
            double Altura = 1.70;
            double IndiceIMC = 29.41;
            // Act
            var IndiceIMCRetornado = imc.CalcularIMC(Peso, Altura);

            // Asserts
            Assert.Equal(IndiceIMC, IndiceIMCRetornado);


        }
    }
}