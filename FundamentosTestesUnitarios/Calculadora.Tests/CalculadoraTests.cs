namespace Calculadora.Tests
{
    public class CalculadoraTests
    {
        [Fact(DisplayName ="Somar_Numeros_Positivos_Soma_Exata")]
        public void SomarNumerosPositivosDeveRetornarSoma_Exata()
        {
            //Arrange
            var calculadora = new Calculadora();
            int numeroUm = 8;
            int numeroDois = 4;
            int resultadoDaSomaEsperado = 12;
            
            //Act
            var resultadoDaSoma = calculadora.Somar(numeroUm, numeroDois);
            
            //Assert
            Assert.Equal(resultadoDaSomaEsperado, resultadoDaSoma);

        }

        [Theory]
        [InlineData(9, 4, 13)]
        [InlineData(-15.2, -5, -20.2)]
        [InlineData(-20, 30, 10)]
        [InlineData(100, -200, -100)]
        [InlineData(-50, -70, -120)]
        public void SomarMuitosNumerosPositivosReaisOuNumerosNegativosReaisDeveRetornarSomaExata(decimal numeroUm, decimal numeroDois, decimal resultadoDaSomaEsperado)
        {
            //Arrange
            var calculadora = new Calculadora();
            
            //Act
            var resultadoDaSoma = calculadora.Somar(numeroUm, numeroDois);

            //Assert
            Assert.Equal(resultadoDaSomaEsperado, resultadoDaSoma);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(-4, 5, -9)]
        [InlineData(-1, 0, -1)]
        [InlineData(0, 0, 0)]
        public void SubtrairNumerosPositivosOuNegativosDeveRetornarSubtracaoExata(decimal numeroUm, decimal numeroDois, decimal resultadoDaSubtracaoEsperada)
        {
            //Arrange
            var calculadora = new Calculadora();
            
            //Act
            var resultadoDaSubtracao = calculadora.Subtrair(numeroUm, numeroDois);

            //Assert
            Assert.Equal(resultadoDaSubtracaoEsperada, resultadoDaSubtracao);
        }

        [Theory]
        [InlineData(4.5, 2.5, 2)]
        [InlineData(-1.2, -2.6, 1.4)]
        [InlineData(-3.8, 5.3, -9.1)]
        [InlineData(-0.0, 0.0, 0.0)]
        public void SubtrairNumerosReaisNegativosOuReaisPositivosDeveRetornarSubtracaoExata(decimal numeroUm, decimal numeroDois, decimal resultadoDaSubtracaoEsperada)
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var resultadoDaSubtracao = calculadora.Subtrair(numeroUm, numeroDois);

            //Assert
            Assert.Equal(resultadoDaSubtracaoEsperada, resultadoDaSubtracao);
        }

        [Theory]
        [InlineData(2.5, 2.7, 6.75)]
        [InlineData(-3.2, -2.6, 8.32)]
        [InlineData(1.8, 4.3, 7.74)]
        [InlineData(-0.0, 0.0, 0.0)]
        public void MultiplicarNumerosReaisNegativosOuReaisPositivosDeveRetornarMultiplicacaoExata(decimal numeroUm, decimal numeroDois, decimal resultadoDaMultiplicacaoEsperada)
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var resultadoDaMultiplicacao = calculadora.Multiplicar(numeroUm, numeroDois);

            //Assert
            Assert.Equal(resultadoDaMultiplicacaoEsperada, resultadoDaMultiplicacao);
        }

        [Fact(DisplayName = "DividirQualquerNumeroPositivoOuNegativoRealPorZeroDeveRetornarMensagemDeExcecao")]
        public void DividirQualquerNumeroPositivoOuNegativoRealPorZeroDeveRetornarMensagemDeExcecao()
        {
            //Arrange
            var calculadora = new Calculadora();
            decimal numeroUm = -4.5m;
            decimal numeroDois = 0.00m;

            //Act
            var excecao = Assert.Throws<DivideByZeroException>(() =>
            calculadora.Dividir(numeroUm, numeroDois));

            //Assert
            Assert.Equal("Não é possível realizar divizão por zero", excecao.Message);
        }

        [Theory]
        [InlineData(5.5, 2.3, 2.39)]
        [InlineData(-3.2, -2.6, 1.23)]
        [InlineData(1.8, 4.3, 0.42)]
        public void DividirNumerosReaisPositivosOuReaisNegativosDeveRetornarDivisaoExata(decimal numeroUm, decimal numeroDois, decimal resultadoDaDivisaoEsperada)
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var resultadoDaDivisao = calculadora.Dividir(numeroUm, numeroDois);

            //Assert
            Assert.Equal(resultadoDaDivisaoEsperada, resultadoDaDivisao, precision: 2);
        }
    }
}
