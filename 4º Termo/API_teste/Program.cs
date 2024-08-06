using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

//Adiciona o servi�o de Controller
builder.Services.AddControllers();


//Adiciona o servi�o swagger
builder.Services.AddSwaggerGen(options =>
{

    //Adiciona informa��es sobre a API no Swagger
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "API Test",
        Description = "API para gerenciamento de testes",

        Contact = new OpenApiContact
        {
            Name = "Everton - DevManh�",
            Url = new Uri("https://github.com/Evertonaraujo88")
        },
    });

    //Configura o swagger para usar o arquivo XML gerado
    // using System.Reflection;
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));

   
});

var app = builder.Build();

//Come�a a configura��o do swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});
//Finaliza a configura��o do swagger

//Adiciona mapeamento dos Controllers
app.MapControllers();

//Adiciona autentifica��o
app.UseAuthentication();

//Adiciona autoriza��o
app.UseAuthorization();

app.UseHttpsRedirection();

app.Run();
