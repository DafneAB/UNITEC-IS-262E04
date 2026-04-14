using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

// IMPORTANTE: Asegúrate de que el namespace coincida con tu proyecto de pruebas
namespace WebApp.IntegrationTest;

public class IntegrationTestPages : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public IntegrationTestPages(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    // Usamos [Theory] para pasarle las 5 rutas distintas a probar
    [Theory]
    [InlineData("/")]              // Prueba 1: Index.cshtml (Ruta raíz)
    [InlineData("/Vanilla")]       // Prueba 2: Vainilla
    [InlineData("/Strawberry")]    // Prueba 3: Fresa
    [InlineData("/Chocolate")]     // Prueba 4: Chocolate
    [InlineData("/Mint")]          // Prueba 5: Menta (¡Cambio hecho!)
    public async Task Get_PaginasDeLaApp_RetornanStatusCode200YHtml(string url)
    {
        // Arrange: Creamos el cliente HTTP virtual
        var client = _factory.CreateClient();

        // Act: Simulamos la navegación a la URL que xUnit nos inyecta en cada iteración
        var response = await client.GetAsync(url);

        // Assert 1: Verificamos que no haya errores de servidor (500) ni no encontradas (404)
        response.EnsureSuccessStatusCode(); 
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        // Assert 2: Verificamos que nos está devolviendo una página web (HTML)
        Assert.Equal("text/html; charset=utf-8", response.Content.Headers.ContentType?.ToString());
    }
}