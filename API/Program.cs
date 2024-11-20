var builder = WebApplication.CreateBuilder(args);


// Adiciona os servi�os ao cont�iner
builder.Services.AddControllers();


// Adiciona a configura��o do Swagger (Documenta��o da API)
builder.Services.AddEndpointsApiExplorer(); // Necess�rio para o Swagger
builder.Services.AddSwaggerGen(); // Gera o Swagger UI



var app = builder.Build();


// Configura o pipeline de requisi��es HTTP

// Habilita o Swagger apenas no ambiente de desenvolvimento
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Gera a documenta��o Swagger
    app.UseSwaggerUI(); // Exibe a interface gr�fica do Swagger (Swagger UI)
}

app.UseHttpsRedirection();  // Redireciona para HTTPS
app.UseAuthorization();  // Habilita a autoriza��o (caso necess�rio)

app.MapControllers();  // Mapeia os controllers da API

app.Run();
