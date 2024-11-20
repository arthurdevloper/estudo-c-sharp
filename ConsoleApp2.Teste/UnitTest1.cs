namespace ConsoleApp2.Teste
{
    public class UnitTest1
    {
        [Fact]
        public void AoSomarDoisNumeros_DeveRetornarSoma1()
        {
            //arrange - prepara o ambiente
            var calculadora = new Calculadora();
            const int primeiroValor = 1;
            const int segudnoValor = 0;

            //act - executa o metodo
            var resultado = calculadora.Somar(primeiroValor, segudnoValor);

            //assert - o que se espera
            Assert.Equal(1, resultado);
        }

        [Fact]
        public void AoSomarDoisNumeros_DeveRetornarResultado2()
        {
            //arrange - prepara o ambiente
            var calculadora = new Calculadora();
            const int primeiroValor = 1;
            const int segudnoValor = 1;

            //act - executa o metodo
            var resultado = calculadora.Somar(primeiroValor, segudnoValor);

            //assert - o que se espera
            Assert.Equal(2, resultado);
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(5, 1, 4)]
        [InlineData(100, 50, 50)]
        [InlineData(0, 0, 0)]
        public void AoDiminuirDoisNumeros_DeveRetornarResultado(int primeiroValor, int segundoValor, int resultado)
        {
            //arrange - prepara o ambiente
            var calculadora = new Calculadora();

            //act - executa o metodo
            var resultadoSubtracao = calculadora.Subtrair(primeiroValor, segundoValor);

            //assert - o que se espera
            Assert.Equal(resultado, resultadoSubtracao);
        }
    }
}