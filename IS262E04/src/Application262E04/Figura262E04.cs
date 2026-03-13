// Archivo: ./src/Application262E04/Figura262E04.cs

public class Figura262E04
{
    // Método estático para calcular el Perímetro
    public static double Perimetro (double lado)
    {
        return lado*4;
    
    }
     // Método estático para calcular el Área
     public static double Area (double diagonalMayor, double diagonalMenor)
     {
        return (diagonalMayor * diagonalMenor) / 2;
     } 
     //Método para cálcular el Volumen del Prisma Romboidal
     public static double
     Volumen (double areaBase, double altura)
     {
        return areaBase * altura;
     }
}