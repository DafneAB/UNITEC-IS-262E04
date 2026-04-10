using Xunit;

namespace Application.IntegrationTest
{
    public class IntegrationTestApplication
    {
        [Theory]
        [InlineData(4, 6, 10, 120)]
        [InlineData(10, 20, 2, 200)]
        [InlineData(2, 4, 5, 20)]
        [InlineData(5, 10, 4, 100)]
        [InlineData(8, 12, 10, 480)]
        [InlineData(6, 8, 2, 48)]
        [InlineData(10, 10, 5, 250)]
        [InlineData(1, 1, 10, 5)]
        [InlineData(3, 7, 2, 21)]
        [InlineData(10, 20, 1, 100)]
        [InlineData(2, 2, 10, 20)]
        [InlineData(5, 5, 4, 50)]
        [InlineData(12, 16, 2, 192)]
        [InlineData(1, 10, 20, 100)]
        [InlineData(2.5, 4, 10, 50)]
        [InlineData(0.5, 4, 10, 10)]
        [InlineData(9, 9, 2, 81)]
        [InlineData(7, 14, 2, 98)]
        [InlineData(11, 22, 1, 121)]
        [InlineData(4, 100, 5, 1000)]
        public void IntegrationTestRomboPrisma_Correcto(double dMayor, double dMenor, double hPrisma, double esperado)
        {
            double areaBase = Figura262E04.Area(dMayor, dMenor);

            double actual = Figura262E04.Volumen(areaBase, hPrisma);

            Assert.Equal(esperado, actual);
        }

        [Fact]
        public void TestPerimetro_Simple()
        {
            double resultado = Figura262E04.Perimetro(5);
            Assert.Equal(20, resultado);
        }
    }
}