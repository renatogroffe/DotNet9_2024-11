using APIContagem;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddSingleton<Contador>();

builder.Services.AddCors();

var app = builder.Build();

app.MapOpenApi();
app.MapScalarApiReference(options =>
{
    options.Title = "API de Contagem";
    options.Theme = ScalarTheme.BluePlanet;
    options.DarkMode = true;
});

app.UseAuthorization();

app.MapControllers();

app.Run();