using healthcalc_pack_dotnet;
using healthcalc_pack_dotnet.Enums;
using healthcalc_pack_dotnet.Interfaces;
using healthcalc_pack_dotnet.Models;

namespace healthcalc_test_dotnet.Pack
{
    public class MacronutrientesTests
    {
        [Fact]
        public void CalculaResultadoMacro()
        {
            //Arrange
            IMacroNutrientes macros = new MacroNutrientes();
            double Peso = 72;
            var ObjetivoFisico = ObjetivoFisicoEnum.Keep;
            var MacrosEsperados = new ResultadoMacroNutrientesModel()
            {
                Proteinas = 144,
                Gorduras = 72,
                Carboidratos = 360
            };

            //Act
            var resultadoMacros = macros.CalcularMacronutrientes(Peso, ObjetivoFisico);

            //Asserts
            Assert.Equivalent(MacrosEsperados, resultadoMacros);
        }
    }
}