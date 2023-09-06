using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

//Adiciona o servico de Controllers
builder.Services.AddControllers();

//Adiciona Servi�o de Jwt Bearer (forma de autentica��o)
//builder.Services.AddAuthentication(Options =>
//{

//    Options.DefaultChallengeScheme = "JwtBearer";
//    Options.DefaultAuthenticateScheme = "JwtBearer";

//})

//.AddJwtBearer("JwtBearer", Options =>
//{
//    Options.TokenValidationParameters = new TokenValidationParameters
//    {
//        //Valida quem esta solicitando  
//        ValidateIssuer = true,

//        //Valida quem esta recebendo
//        ValidateAudience = true,

//        //Valida se o tempo de expira��o ser� validado
//        ValidateLifetime = true,

//        //Forma decriptografia que valida a chave de autentica��o
//        IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("filmes-chave-autenticacao-webapi-dev")),

//        //Valida o tempo de expira��o do Token
//        ClockSkew = TimeSpan.FromMinutes(5),

//        //Nome do issuer (de onde est� vindo)
//        ValidIssuer = "webapi.filmes.manha",

//        //Nome do Audience (para onde est� indo)
//        ValidAudience = "webapi.filmes.manha",

//    };

//});



//Adiciona o servico de Swagger
builder.Services.AddSwaggerGen(options =>
{

    //Adiciona informa��es sobre a API no Swagger
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "API InLock",
        Description = "API para gerenciamento de Jogos - Introdu��o da sprint 2 (backend API)",

        Contact = new OpenApiContact
        {
            Name = "Everton - DevManh�",
            Url = new Uri("https://github.com/Evertonaraujo88")
        },

    });

    ////Configura o Swagger para usar o arquivo XML gerado.
    //var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    //options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));

    //Usando a autentica�ao no Swagger
    //options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    //{
    //    Name = "Authorization",
    //    Type = SecuritySchemeType.ApiKey,
    //    Scheme = "Bearer",
    //    BearerFormat = "JWT",
    //    In = ParameterLocation.Header,
    //    Description = "Value: Bearer TokenJWT ",
    //});
    //options.AddSecurityRequirement(new OpenApiSecurityRequirement
    //{
    //    {
    //        new OpenApiSecurityScheme
    //        {
    //            Reference = new OpenApiReference
    //            {
    //                Type = ReferenceType.SecurityScheme,
    //                Id = "Bearer"
    //            }
    //        },
    //        new string[] {}
    //    }
    //});


});


var app = builder.Build();

//Habilita o middleware para atender ao documento JSON gerado e � interface do usu�rio do Swagger
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


//app.UseAuthentication();

//app.UseAuthorization();//especificar as roules nos verbos(quem tem acesso)

app.UseHttpsRedirection();

app.Run();


