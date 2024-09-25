using AppNewTDDTestCalculadora;

namespace TesteCalculadora;

public class UnitTest1
{
    [Fact]
    public void TestSomar()
    {
        Calculadora calculadora = new Calculadora();

        int resultado = calculadora.somar(1,2);

        Assert.Equal(3, resultado);
    }

    [Theory]
    [InlineData(1,2,3)]
    [InlineData(4,5,9)]
    public void TestSomarNovo(int val1, int val2, int resultado)
    {
        Calculadora calculadora = new Calculadora();

        int resultadoCalculado = calculadora.somar(val1,val2);

        Assert.Equal(resultado, resultadoCalculado);
    }
}