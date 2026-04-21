

using Project.Application.Interfaces;
using Project.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 1. REGISTRAR SERVICIOS
builder.Services.AddControllers();
builder.Services.AddOpenApi();

// 2. CONFIGURAR LA INYECCIÓN DE DEPENDENCIAS
builder.Services.AddSingleton<IExpenseRepository, ExpenseRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
