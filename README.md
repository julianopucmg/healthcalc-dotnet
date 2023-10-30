# healthcalc_pack_dotnet

**healthcalc_pack_dotnet** é uma biblioteca .NET que fornece funcionalidades para calcular o Índice de Massa Corporal (IMC) e classificá-lo com base em critérios predefinidos. Essa biblioteca é útil para aplicativos relacionados à saúde e fitness que requerem cálculos e classificações de IMC.

## Instalação

Você pode instalar esta biblioteca por meio do Gerenciador de Pacotes NuGet em seu projeto .NET. Para fazer isso, execute o seguinte comando em seu diretório de projeto:

```shell
dotnet add package healthcalc_pack_dotnet
```

## Uso

Para calcular o IMC e classificá-lo, siga estas etapas:

1. Importe o namespace `healthcalc_pack_dotnet`:

```csharp
using healthcalc_pack_dotnet;
```

2. Crie uma instância da classe `IMC`:
  

```csharp
IMC imcCalculator = new IMC();
```

3. Calcule o IMC chamando o método `CalcularIMC` com o peso da pessoa (em quilogramas) e a altura (em metros):
  

```csharp
double peso = 70,0; // Peso em quilogramas
double altura = 1,75; // Altura em metros
double imc = imcCalculator.CalcularIMC(peso, altura);
```

4. Classifique o IMC usando o método `RetornarClassificacaoIMC`:
  

```csharp
string classificacao = imcCalculator.RetornarClassificacaoIMC(imc);
```

1. A classificação será uma das seguintes:
  
  - "ABAIXO DO PESO"
  - "PESO NORMAL"
  - "SOBREPESO"
  - "OBESIDADE I"
  - "OBESIDADE II"
  - "OBESIDADE III"

Observe que a biblioteca verifica a altura inválida (igual a 0) e lança uma exceção nesses casos.

## Exemplo

Aqui está um exemplo de como usar a biblioteca para calcular o IMC e classificá-lo:

```csharp
using healthcalc_pack_dotnet;
using System;

class Program
{
    static void Main()
    {
        IMC imcCalculator = new IMC();
        double peso = 70,0; // Peso em quilogramas
        double altura = 1,75; // Altura em metros

        try
        {
            double imc = imcCalculator.CalcularIMC(peso, altura);
            string classificacao = imcCalculator.RetornarClassificacaoIMC(imc);

            Console.WriteLine($"IMC: {imc}");
            Console.WriteLine($"Classificação: {classificacao}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
    }
}
```

# MacroNutrientes

**MacroNutrientes** é uma classe em C# que fornece funcionalidades para calcular a distribuição de macronutrientes com base no objetivo físico selecionado. Essa classe é útil para aplicativos relacionados a nutrição e fitness que requerem o cálculo de proteínas, gorduras e carboidratos com base no objetivo físico do usuário.

## Uso

Para calcular a distribuição de macronutrientes com base no objetivo físico, siga estas etapas:

1. Importe o namespace necessário:

```csharp
using healthcalc_pack_dotnet
```

2. Crie uma instância da classe `MacroNutrientes`:
  

```csharp
MacroNutrientes calculadora = new MacroNutrientes();
```

3. Chame o método `CalcularMacronutrientes` com o peso da pessoa (em quilogramas) e o objetivo físico desejado:
  

```csharp
double peso = 70.0; // Peso em quilogramas
ObjetivoFisicoEnum objetivo = ObjetivoFisicoEnum.Cutting; // Substitua pelo objetivo desejado

ResultadoMacroNutrientesModel resultado = calculadora.CalcularMacronutrientes(peso, objetivo);
```

4. O método retornará um objeto `ResultadoMacroNutrientesModel` com a distribuição de proteínas, gorduras e carboidratos calculada com base no objetivo físico selecionado.
  

## Objetivos Físicos

A classe `ObjetivoFisicoEnum` é uma enumeração que representa os objetivos físicos possíveis. Você pode escolher entre os seguintes valores:

- `Cutting`: Representa o objetivo de reduzir a gordura corporal.
- `Bulking`: Representa o objetivo de ganhar massa muscular.
- `Keep`: Representa o objetivo de manter o peso atual.

## Exemplo

Aqui está um exemplo de como usar a classe `MacroNutrientes` para calcular a distribuição de macronutrientes com base no objetivo físico:

```csharp
using SeuNamespaceAqui;
using System;

class Program
{
    static void Main()
    {
        MacroNutrientes calculadora = new MacroNutrientes();
        double peso = 70.0; // Peso em quilogramas
        ObjetivoFisicoEnum objetivo = ObjetivoFisicoEnum.Cutting;

        ResultadoMacroNutrientesModel resultado = calculadora.CalcularMacronutrientes(peso, objetivo);

        Console.WriteLine("Distribuição de Macronutrientes:");
        Console.WriteLine($"Proteínas: {resultado.Proteinas}g");
        Console.WriteLine($"Gorduras: {resultado.Gorduras}g");
        Console.WriteLine($"Carboidratos: {resultado.Carboidratos}g");
    }
}
```

## Licença

Esta biblioteca é fornecida sob a [Licença MIT](https://chat.openai.com/c/LICENSE).

## Autor

Esta biblioteca foi criada por alunos da PUC Minas como trabalho final da matéria de # Projeto Integrado em Engenharia de Software. Se você tiver alguma dúvida ou feedback, não deixe de abrir uma Issue.

Aproveite o uso do **healthcalc_pack_dotnet** para cálculos e classificações de IMC!
