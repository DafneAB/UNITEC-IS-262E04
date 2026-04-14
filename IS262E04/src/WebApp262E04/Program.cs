//  Archivo: -/src/WebApplication262E04/Pages.cs
var builder = WebApplication.CreateBuilder(args);

// Inyectar el servicio de Add Razor Pages
builder.Services.AddRazorPages();

var app = builder.Build();

//Mapear las rutas hacia la carpeta Pages
app.MapRazorPages();

app.Run();

//OBLIGATORIA PARA PRUEBAS DE INTEGRACIÓN
public partial class Program { }
