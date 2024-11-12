using Xunit;
using MeuProjeto;
using MeuProjeto.Tests;

public class UnitTest1
{
    [Fact]
    public void Soma_DeveRetornarResultadoCorreto()
    {
        // Arrange
        var calculadora = new Calculadora();
        
        // Act
        var resultado = calculadora.Soma(2, 3);
        
        // Assert
        Assert.Equal(5, resultado);
    }
    [Fact]
    public void Subtracao_DeveRetornarResultadoCorreto()
    {
        // Arrange
        var calculadora = new Calculadora();

        // Act
        var resultado = calculadora.Subtracao(5, 3);

        // Assert
        Assert.Equal(2, resultado);
    }

    [Fact]
    public void Multiplicacao_DeveRetornarResultadoCorreto()
    {
        // Arrange
        var calculadora = new Calculadora();

        // Act
        var resultado = calculadora.Multiplicacao(2, 3);

        // Assert
        Assert.Equal(6, resultado);
    }

    [Fact]
    public void Historico_DeveSalvarOperacoesCorretamente()
    {
        // Arrange
        var calculadora = new Calculadora();
        
        // Act
        calculadora.Soma(2, 3);
        calculadora.Subtracao(5, 2);
        calculadora.Multiplicacao(3, 3);
        
        var historico = calculadora.ObterHistorico();

        // Assert
        Assert.Equal(3, historico.Count);
        Assert.Equal("Soma: 2 + 3 = 5", historico[0]);
        Assert.Equal("Subtracao: 5 - 2 = 3", historico[1]);
        Assert.Equal("Multiplicacao: 3 * 3 = 9", historico[2]);
    }
}
