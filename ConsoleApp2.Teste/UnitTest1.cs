namespace ConsoleApp2.Teste
{
    public class UnitTest1
    {
        [Fact]
        public void AoSomarDoisNumeros_DeveRetornarSoma()
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
    }
}