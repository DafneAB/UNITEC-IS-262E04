public class UnitTestApplication 
{
    // PRUEBA 1: PERÍMETRO DEL ROMBO
    [Theory]
    [InlineData(1, 4)]
    [InlineData(2, 8)]
    [InlineData(5, 20)]
    [InlineData(10, 40)]
    [InlineData(12, 48)]
    [InlineData(25, 100)]
    [InlineData(0.5, 2)]
    [InlineData(1.5, 6)]
    [InlineData(3.2, 12.8)]
    [InlineData(100, 400)]
    [InlineData(7, 28)]
    [InlineData(9, 36)]
    [InlineData(15, 60)]
    [InlineData(20, 80)]
    [InlineData(50, 200)]
    [InlineData(0.25, 1)]
    [InlineData(11, 44)]
    [InlineData(8, 32)]
    [InlineData(6, 24)]
    [InlineData(3, 12)]
    public void Perimetro_LadoValido_Correcto(double lado, double expected) 
    {
        double actual = Figura262E04.Perimetro(lado);
        Assert.Equal(expected, actual, 3);
    }

    // PRUEBA 2: ÁREA DEL ROMBO
    [Theory]
    [InlineData(4, 6, 12)]
    [InlineData(10, 20, 100)]
    [InlineData(2, 4, 4)]
    [InlineData(5, 10, 25)]
    [InlineData(8, 12, 48)]
    [InlineData(6, 8, 24)]
    [InlineData(10, 10, 50)]
    [InlineData(1, 1, 0.5)]
    [InlineData(3, 7, 10.5)]
    [InlineData(100, 200, 10000)]
    [InlineData(2, 2, 2)]
    [InlineData(5, 5, 12.5)]
    [InlineData(12, 16, 96)]
    [InlineData(1, 10, 5)]
    [InlineData(2.5, 4, 5)]
    [InlineData(0.5, 4, 1)]
    [InlineData(9, 9, 40.5)]
    [InlineData(7, 14, 49)]
    [InlineData(11, 22, 121)]
    [InlineData(4, 100, 200)]

    public void Area_DiagonalesValidas_Correcto(double diagonalMayor, double diagonalMenor, double expected) 
    {
        double actual = Figura262E04.Area(diagonalMayor, diagonalMenor);
        Assert.Equal(expected, actual, 3);
    }

    // PRUEBA 3: VOLUMEN DEL PRISMA ROMBOIDAL
    [Theory]
   [InlineData(12, 10, 120)]
   [InlineData(100, 2, 200)]
   [InlineData(4, 5, 20)]
   [InlineData(25, 4, 100)]
   [InlineData(48, 10, 480)]
   [InlineData(24, 2, 48)]
   [InlineData(50, 5, 250)]
   [InlineData(0.5, 10, 5)]
   [InlineData(10.5, 2, 21)]
   [InlineData(100, 1, 100)]
   [InlineData(2, 10, 20)]
   [InlineData(12.5, 4, 50)]
   [InlineData(96, 2, 192)]
   [InlineData(5, 20, 100)]
   [InlineData(5, 10, 50)]
   [InlineData(1, 10, 10)]
   [InlineData(40.5, 2, 81)]
   [InlineData(49, 2, 98)]
   [InlineData(121, 1, 121)]
   [InlineData(200, 5, 1000)]

    public void Volumen_AreaYAlturaValidas_Correcto(double areaBase, double altura, double expected) 
    {
        double actual = Figura262E04.Volumen(areaBase, altura);
        Assert.Equal(expected, actual, 3);
    }
}