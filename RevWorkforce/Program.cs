using Microsoft.EntityFrameworkCore;
using RevWorkforce.Models;
using RevWorkforce.Controllers;
using RevWorkforce.Services;
using RevWorkforce.Data;

var builder = WebApplication.CreateBuilder(args);

var myBadCorsPolicy = "_myBadCorsPolicy";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: myBadCorsPolicy,
    policy =>
    {
        policy.AllowAnyOrigin();
        policy.AllowAnyMethod();
        policy.AllowAnyHeader();
    });
});

// Add services to the container.

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

app.UseCors(myBadCorsPolicy);

app.UseAuthorization();

app.MapControllers();

app.Run();
