var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

// postar documento - enviar para S3 e disparar evento
app.MapPost("/postdocuments", async (HttpRequest request) =>
{
    if (request.HasFormContentType)
    {
        return Results.BadRequest("O conteúdo deve ser enviado como multipart/form-data");
    }

    var form = await request.ReadFormAsync();
    var file = form.Files.GetFile("pdf");

    if (file is null || file.Length == 0)
    {
        return Results.BadRequest("O arquivo PDF precisa ser enviado.");
    }

    // chamar service p/ armazenar

    return Results.Ok("Arquivo salvo com sucesso.");
})
.WithName("PostDocuments")
.WithOpenApi();

// ver relatório

app.MapGet("/getreport", () =>
{

}).WithName("GetReport").
WithOpenApi();

app.Run();

