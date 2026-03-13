    // Archivo: ./src/ConsoleAPP262E04/Pages.cs

    //1. Declaracción de variables
    double lado = 7;
    double diagonalMayor= 9;
    double diagonalMenor= 3;
    double altura= 12;
    // Variable preparada para futuros cálculos de volumen

    //2. Consumo de la Librería de Clases (Invocación de métodos estáticos)
    double perimetro= Figura262E04.Perimetro(lado);
    double area= Figura262E04.Area(diagonalMayor, diagonalMenor);
    double volumen= Figura262E04.Volumen(area, altura);

    //3. Salida en Consola
    Console.WriteLine($"El perímetro de un rombo de {lado}cm por lado es {perimetro}cm");
    Console.WriteLine($"El area de un rombo de {diagonalMayor}cm por {diagonalMenor}cm es {area}cm2");
    Console.WriteLine($"El volumen del prisma romboidal con altura de {altura}cm es {volumen}cm3");
