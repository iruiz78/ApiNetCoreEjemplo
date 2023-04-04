using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApplication9.ContextoSQL;
using WebApplication9.Modelos;
using WebApplication9.Repocitorio;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddTransient
//builder.Services.AddScoped
//builder.Services.AddSingleton

builder.Services.AddScoped<IDBGestor<Cliente>, ClienteRepositorio>();
builder.Services.AddScoped<IDBGestor<Factura>, FacturaRepositorio>();

builder.Services.AddDbContext<ContextoGenerico>(options =>
              options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
