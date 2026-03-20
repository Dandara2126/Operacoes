
// Cria um objeto responsável por configurar a aplicação ASP.NET
var builder = WebApplication.CreateBuilder(args);

// Define o endereço e a porta em que a aplicação irá escutar requisições HTTP
builder.WebHost.UseUrls("http://localhost:8000");

// Constrói a aplicação web a partir das configurações definidas no builder
var app = builder.Build();

// Definição de rotas HTTP do tipo GET 
app.MapGet("/", () => "Olá, os números utilizados foram 34 e 13");
app.MapGet("/soma", () => new {Resultado=34+13});
app.MapGet("/subtracao", () => new {Resultado=34-13});
app.MapGet("/multiplicacao", () => new {Resultado=34*13});
app.MapGet("/divisao", () => new {Resultado=34/13});


// Inicia o servidor web é iniciado e passa a aguardar requisições HTTP dos clientes
app.Run();