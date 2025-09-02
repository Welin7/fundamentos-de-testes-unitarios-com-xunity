namespace Calculadora.Tests
{
    public class CalculadoraTests
    {
        [Fact]
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
    }
}
