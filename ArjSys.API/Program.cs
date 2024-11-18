var builder = WebApplication.CreateBuilder(args);


// =================================================================
// Adiciona servi�os ao cont�iner

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// =================================================================
// Configura o HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
