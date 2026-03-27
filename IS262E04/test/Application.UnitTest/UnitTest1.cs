using Xunit;

namespace Application.UnitTest;

public class UnitTestApplication 
{
    // PRUEBA 1: PERÍMETRO DEL ROMBO
    [Theory]
    [InlineData(5, 20)]   // Lado 5 -> Perímetro 20
    [InlineData(10, 40)]  // Lado 10 -> Perímetro 40
    [InlineData(2.5, 10)] // Lado 2.5 -> Perímetro 10
    public void Perimetro_LadoValido_Correcto(double lado, double expected) 
    {
        double actual = Figura262E04.Perimetro(lado);
        Assert.Equal(expected, actual);
    }

    // PRUEBA 2: ÁREA DEL ROMBO
    [Theory]
    [InlineData(10, 8, 40)] // D=10, d=8 -> (10*8)/2 = 40
    [InlineData(6, 4, 12)]  // D=6, d=4 -> (6*4)/2 = 12
    [InlineData(12, 10, 60)]// D=12, d=10 -> (12*10)/2 = 60
    public void Area_DiagonalesValidas_Correcto(double diagonalMayor, double diagonalMenor, double expected) 
    {
        double actual = Figura262E04.Area(diagonalMayor, diagonalMenor);
        Assert.Equal(expected, actual);
    }

    // PRUEBA 3: VOLUMEN DEL PRISMA ROMBOIDAL
    [Theory]
    [InlineData(40, 5, 200)]  // Área base 40, Altura 5 -> Volumen 200
    [InlineData(12, 10, 120)] // Área base 12, Altura 10 -> Volumen 120
    [InlineData(60, 2, 120)]  // Área base 60, Altura 2 -> Volumen 120
    public void Volumen_AreaYAlturaValidas_Correcto(double areaBase, double altura, double expected) 
    {
        double actual = Figura262E04.Volumen(areaBase, altura);
        Assert.Equal(expected, actual);
    }
}