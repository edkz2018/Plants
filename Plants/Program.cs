using DataBase.Context;
using Microsoft.EntityFrameworkCore;
using Models;
using Services.Flowers;
using Services.Plants;
using System;

var builder = WebApplication.CreateBuilder(args);

string? connection = builder.Configuration.GetConnectionString("DefaultConnection");

// добавляем контекст ApplicationContext в качестве сервиса в приложение
builder.Services.AddDbContext<DateBaseContext>(options => options.UseSqlServer(connection));

builder.Services.AddScoped<IPlantService, PlantsService>();
builder.Services.AddScoped<IWorkWithPlantService, WorkWithPlantService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
