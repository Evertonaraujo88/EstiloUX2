var builder = WebApplication.CreateBuilder(args);

//Adiciona o servico de Controllers
builder.Services.AddControllers();

//Adiciona o servico de Swagger
builder.Services.AddSwaggerGen();

var app = builder.Build();

//Habilita o middleware para atender ao documento JSON gerado e à interface do usuário do Swagger
//Comeca a configuracao do Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Finaliza a configuracao do Swagger
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

//Adiciona maoeamento dos Controllers
app.MapControllers();

app.UseHttpsRedirection();

app.Run();
