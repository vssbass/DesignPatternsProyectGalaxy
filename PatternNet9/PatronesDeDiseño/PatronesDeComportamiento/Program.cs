using Microsoft.AspNetCore.Builder;
using StrategyTipoEnvio.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//builder.Services.AddOpenApi();
builder.Services.AddScoped<CostoEnvioService>();
builder.Services.AddScoped<IEnvioStrategy, EnvioAereo>();
builder.Services.AddScoped<IEnvioStrategy, EnvioTerrestre>();
builder.Services.AddScoped<IEnvioStrategy, EnvioLocal>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
