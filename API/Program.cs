var builder = WebApplication.CreateBuilder(args);


// Adiciona os serviços ao contêiner
builder.Services.AddControllers();


// Adiciona a configuração do Swagger (Documentação da API)
builder.Services.AddEndpointsApiExplorer(); // Necessário para o Swagger
builder.Services.AddSwaggerGen(); // Gera o Swagger UI



var app = builder.Build();


// Configura o pipeline de requisições HTTP

// Habilita o Swagger apenas no ambiente de desenvolvimento
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Gera a documentação Swagger
    app.UseSwaggerUI(); // Exibe a interface gráfica do Swagger (Swagger UI)
}

app.UseHttpsRedirection();  // Redireciona para HTTPS
app.UseAuthorization();  // Habilita a autorização (caso necessário)

app.MapControllers();  // Mapeia os controllers da API

app.Run();
