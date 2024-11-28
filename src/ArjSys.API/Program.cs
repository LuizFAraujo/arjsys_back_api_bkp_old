using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using ArjSys.Infraestrutura;
using ArjSys.Infraestrutura.Context;
using ArjSys.Aplicacao;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add DbContext
builder.Services.AddDbContext<ArjSysContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add application services
builder.Services.AddApplicationServices();

// Add infrastructure services
builder.Services.AddInfrastructureServices();

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




//    using Microsoft.EntityFrameworkCore;
//    using ArjSys.API.Configurations;
//    using ArjSys.Infraestrutura.Data;
//    
//    var builder = WebApplication.CreateBuilder(args);
//    
//    
//    // =================================================================
//    // Adiciona serviços ao contêiner
//    
//    builder.Services.AddControllers();
//    builder.Services.AddEndpointsApiExplorer();
//    
//    // Adiciona o AutoMapper
//    builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
//    
//    // Adiciona a configuração do Swagger
//    builder.Services.AddEndpointsApiExplorer();
//    // builder.Services.AddSwaggerGen();
//    builder.Services.AddSwaggerConfiguration();
//    
//    
//    // Configura o Entity Framework e o banco de dados
//    builder.Services.AddDbContext<ArjSysDbContext>(options =>
//        options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
//    
//    // Constrói a aplicação.
//    var app = builder.Build();
//    
//    // Configura o middleware para exibir o Swagger
//    if (app.Environment.IsDevelopment())
//    {
//        // app.UseSwagger();
//        // app.UseSwaggerUI();
//        app.UseSwaggerConfiguration(); // Usa a configuração personalizada do Swagger
//    }
//    
//    // =================================================================
//    // Configura o HTTP request pipeline.
//    
//    app.UseHttpsRedirection(); // Redireciona as requisições HTTP para HTTPS
//    app.UseAuthorization(); // Habilita o middleware de autorização para controle de acesso às APIs
//    app.MapControllers(); // Mapeia os controllers da API para que as rotas sejam reconhecidas
//    
//    app.Run();
