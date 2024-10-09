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
app.MapPost("/postdocuments", () =>
{

})
.WithName("PostDocuments")
.WithOpenApi();

// ver relatório

app.MapGet("/getreport", () =>
{

}).WithName("GetReport").
WithOpenApi();

app.Run();

