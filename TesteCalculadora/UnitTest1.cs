using AppNewTDDTestCalculadora;

namespace TesteCalculadora;

public class UnitTest1
{

    public Calculadora construirClasse()
    {
        string data = "25/05/2024";
        Calculadora calculadora = new Calculadora(data);
        return calculadora;
    }

    [Fact]
    public void TestSomarSimples()
    {
        Calculadora calculadora = construirClasse();

        int resultado = calculadora.somar(1,2);

        Assert.Equal(3, resultado);
    }

    [Theory]
    [InlineData(1,2,3)]
    [InlineData(4,5,9)]
    public void TestSomar(int val1, int val2, int resultado)
    {
        Calculadora calculadora = construirClasse();

        int resultadoCalculado = calculadora.somar(val1,val2);

        Assert.Equal(resultado, resultadoCalculado);
    }

    [Theory]
    [InlineData(1,2,-1)]
    [InlineData(2,1,1)]
    public void TestSubtrair(int val1, int val2, int resultado)
    {
        Calculadora calculadora = construirClasse();

        int resultadoCalculado = calculadora.subtrair(val1,val2);

        Assert.Equal(resultado, resultadoCalculado);
    }

    [Theory]
    [InlineData(1,2,2)]
    [InlineData(2,1,2)]
    public void TestMultiplicar(int val1, int val2, int resultado)
    {
        Calculadora calculadora = construirClasse();

        int resultadoCalculado = calculadora.multiplicar(val1,val2);

        Assert.Equal(resultado, resultadoCalculado);
    }

    [Theory]
    [InlineData(4,2,2)]
    [InlineData(2,1,2)]
    public void TestDividir(int val1, int val2, int resultado)
    {
        Calculadora calculadora = construirClasse();

        int resultadoCalculado = calculadora.dividir(val1,val2);

        Assert.Equal(resultado, resultadoCalculado);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Calculadora calculadora = construirClasse();

        Assert.Throws<DivideByZeroException>(() => calculadora.dividir(3,0));
    }

    [Fact]
    public void TestarHistorico()
    {
        Calculadora calculadora = construirClasse();

        calculadora.somar(1,2);
        calculadora.somar(2,2);
        calculadora.somar(1,3);
        calculadora.somar(2,3);

        var lista = calculadora.historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count());
    }
}