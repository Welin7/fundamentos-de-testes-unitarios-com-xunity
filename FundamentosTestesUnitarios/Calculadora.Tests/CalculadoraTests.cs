namespace Calculadora.Tests
{
    public class CalculadoraTests
    {
        [Fact(DisplayName ="Somar_Numeros_Positivos_Soma_Exata")]
        public void Somar_Numeros_Positivos_Deve_Retornar_Soma_Exata()
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
        [InlineData(8, 4, 12)]
        [InlineData(15, 5, 20)]
        [InlineData(20, 30, 50)]
        [InlineData(100, 200, 300)]
        [InlineData(50, 60, 100)]
        public void SomarMuitosNumerosPositivosDeveRetornarSomaExata(int numeroUm, int numeroDois, int resultadoDaSomaEsperado)
        {
            //Arrange
            var calculadora = new Calculadora();
            
            //Act
            var resultaDaSoma = calculadora.Somar(numeroUm, numeroDois);

            //Assert
            Assert.Equal(resultadoDaSomaEsperado, resultaDaSoma);
        }
    }
}
