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
            var resultaDaSoma = calculadora.Somar(numeroUm, numeroDois);
            
            //Assert
            Assert.Equal(resultadoDaSomaEsperado, resultaDaSoma);

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
            var resultaDaSoma = calculadora.Somar(numeroUm, numeroDois);

            //Assert
            Assert.Equal(resultadoDaSomaEsperado, resultaDaSoma);
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
            var resultaDaSubtracao = calculadora.Subtrair(numeroUm, numeroDois);

            //Assert
            Assert.Equal(resultadoDaSubtracaoEsperada, resultaDaSubtracao);
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
            var resultaDaSubtracao = calculadora.Subtrair(numeroUm, numeroDois);

            //Assert
            Assert.Equal(resultadoDaSubtracaoEsperada, resultaDaSubtracao);
        }
    }
}
