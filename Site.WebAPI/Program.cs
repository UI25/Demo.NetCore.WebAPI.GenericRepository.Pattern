using Microsoft.EntityFrameworkCore;
using Site.Models.Data;
using Site.WebAPI.Extensions;
using Site.WebAPI.Infrastructure.Mapper;
using Site.WebAPI.Services;

var builder = WebApplication.CreateBuilder(args);

var Configuration = builder.Configuration;
var Assembly = typeof(Program).Assembly.GetName().Name;


// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDIServices(builder.Configuration);
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfile));  

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(o =>
    {
        o.SwaggerEndpoint("/swagger/v1/swagger.json", "StoreAPI - v1");
        o.DocumentTitle = "JWT StoreAPI";
    });
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
