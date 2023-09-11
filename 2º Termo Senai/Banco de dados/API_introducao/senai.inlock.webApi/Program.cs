using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

//Adiciona o servico de Controllers
builder.Services.AddControllers();



//Adiciona o servico de Swagger
builder.Services.AddSwaggerGen(options =>
{

    //Adiciona informações sobre a API no Swagger
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "API InLock",
        Description = "API para gerenciamento de Jogos - Introdução da sprint 2 (backend API)",

        Contact = new OpenApiContact
        {
            Name = "Everton - DevManhã",
            Url = new Uri("https://github.com/Evertonaraujo88")
        },

    });

    //Configura o Swagger para usar o arquivo XML gerado.
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));

   

});


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



