using Calculadora.Services;

namespace CalcTests
{
    public class CalcuradoraTest
    {
        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(10, 1, 12)]
        public void SomarDoisNumerosERetornarOResultado(int num1, int num2, int resultado)
        {
            //Arrange /Act
            CalcService calc = new CalcService();

            int resultadoEsperado = calc.Somar(num1, num2);

            //Assert
            Assert.Equal(resultado, resultadoEsperado);
        }

        [Theory]
        [InlineData(15, 5, 10)]
        [InlineData(15, 8, 7)]
        public void SubtrairUmValorERetornarOResultado(int num1, int num2, int resultado)
        {
            //Arrange /Act
            CalcService calc = new CalcService();

            int resultadoEsperado = calc.Subtrair(num1, num2);

            //Assert
            Assert.Equal(resultado, resultadoEsperado);
        }

        [Theory]
        [InlineData(21, 3, 9)]
        [InlineData(18, 9, 2)]
        public void DividirUmNumeroERetornarOResultado(int num1, int num2, int resultado)
        {
            //Arrange /Act
            CalcService calc = new CalcService();

            int resultadoEsperado = calc.Dividir(num1, num2);

            //Assert
            Assert.Equal(resultado, resultadoEsperado);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            //Arrange /Act
            CalcService calc = new CalcService();

            // Assert
            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }

        [Theory]
        [InlineData(3, 9, 21)]
        [InlineData(2, 9, 18)]
        public void MultiplicarDoisNumerosERetornarOResultado(int num1, int num2, int resultado)
        {
            //Arrange /Act
            CalcService calc = new CalcService();

            int resultadoEsperado = calc.Multiplicar(num1, num2);

            //Assert
            Assert.Equal(resultado, resultadoEsperado);
        }
    }
}