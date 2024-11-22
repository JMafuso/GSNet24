using GSNet24.Context;
using GSNet24.Repositories.Interface;
using GSNet24.Repositories.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppContextDb>(options => options.UseOracle(builder.Configuration.GetConnectionString("OracleConnection")));
builder.Services.AddTransient<IAparelhoRepository, AparelhoRepository>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(

    c =>
    {
        c.SwaggerDoc(
            "v1",
            new Microsoft.OpenApi.Models.OpenApiInfo
            {
                Title = "FIAP - CADASTRO APARELHO",
                Description = "Solução destinada a gerenciar aparelhos",
                Version = "v1",
                Contact = new OpenApiContact
                {
                    Name = "FIAP - JRT",
                    Url = new System.Uri("http://fiap.com.br"),
                    Email = "contato@suporterjt.com.br"
                }
            }
            );

        c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        {
            Name = "Authorization",
            Type = SecuritySchemeType.ApiKey,
            Scheme = "Bearer",
            BearerFormat = "JWT",
            In = ParameterLocation.Header,
            Description = "Basic Authorization Header"
        });
    }
    );

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
