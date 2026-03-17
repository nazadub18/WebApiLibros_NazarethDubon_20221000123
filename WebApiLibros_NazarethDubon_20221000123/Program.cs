using Microsoft.EntityFrameworkCore;
using WebApiLibros_NazarethDubon_20221000123.Data;
using WebApiLibros_NazarethDubon_20221000123.Data.Repositories;
using WebApiLibros_NazarethDubon_20221000123.Services.AppServices;
using WebApiLibros_NazarethDubon_20221000123.Services.DomainServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<LibrosDbContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("LibrosDB")));

builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddScoped<ILibroRepository, LibroRepository>();

builder.Services.AddScoped<ICategoriaDomainService, CategoriaDomainService>();
builder.Services.AddScoped<ILibroDomainService, LibroDomainService>();


builder.Services.AddScoped<ICategoriaAppService, CategoriaAppService>();
builder.Services.AddScoped<ILibroAppService,LibroAppService>();


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();