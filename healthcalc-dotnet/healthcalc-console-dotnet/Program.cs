using healthcalc_pack_dotnet;
using healthcalc_pack_dotnet.Interfaces;

IIMC objeto = new IMC();

var imc = objeto.CalcularIMC(73.00, 1.72);
var resultado = objeto.RetornarClassificacaoIMC(imc);

Console.WriteLine("Seu resultado é: " + resultado);