using Calculadora.Services;

namespace CalcTests
{
    public class CalcuradoraTest
    {
        public CalcService ConstruirCalcService()
        {
            string data = DateTime.Now.ToString();
            CalcService calc = new CalcService(data);
            return calc;
        }

        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(10, 1, 11)]
        public void SomarDoisNumerosERetornarOResultado(int num1, int num2, int resultado)
        {
            //Arrange /Act
            CalcService calc = ConstruirCalcService();

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
            CalcService calc = ConstruirCalcService();

            int resultadoEsperado = calc.Subtrair(num1, num2);

            //Assert
            Assert.Equal(resultado, resultadoEsperado);
        }

        [Theory]
        [InlineData(21, 3, 7)]
        [InlineData(18, 9, 2)]
        public void DividirUmNumeroERetornarOResultado(int num1, int num2, int resultado)
        {
            //Arrange /Act
            CalcService calc = ConstruirCalcService();

            int resultadoEsperado = calc.Dividir(num1, num2);

            //Assert
            Assert.Equal(resultado, resultadoEsperado);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            //Arrange /Act
            CalcService calc = ConstruirCalcService();

            // Assert
            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }

        [Theory]
        [InlineData(3, 9, 27)]
        [InlineData(2, 9, 18)]
        public void MultiplicarDoisNumerosERetornarOResultado(int num1, int num2, int resultado)
        {
            //Arrange /Act
            CalcService calc = ConstruirCalcService();

            int resultadoEsperado = calc.Multiplicar(num1, num2);

            //Assert
            Assert.Equal(resultado, resultadoEsperado);
        }
        [Fact]
        public void TestarHistoricoComBaseEmUmaListaDeTexto()
        {
            //Arrange
            CalcService calc = ConstruirCalcService();

            //Act
            calc.Somar(3, 2);
            calc.Multiplicar(3, 2);
            calc.Subtrair(3, 2);
            calc.Dividir(12, 6);

            var lista = calc.Historico();

            //Assert
            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}