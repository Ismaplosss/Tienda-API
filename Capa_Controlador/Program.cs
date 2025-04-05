using Capa_Datos;
using Capa_Interfaces;
using Capa_Negocio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Inyección de dependencias correctamente colocada ANTES del Build
builder.Services.AddScoped<IlistadoProducto, CN_Producto>();
builder.Services.AddScoped<IProducto, CD_Producto>();

var app = builder.Build();

// Configuración del pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
