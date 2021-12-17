//using ApiRest.Negocio;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
//builder.Services.AddSingleton<NE_Aluno, NE_Aluno>();

var app = builder.Build();

app.MapControllers();

//app.MapGet("/", () => "Alo mundo");

//app.MapGet("/{nomeAluno}/{idade}", (string nomeAluno, int idade) =>
//    {
//        return Results.Ok($"Ola {nomeAluno} voce tem {idade} anos!");
//    });


//app.MapPost("/", (Usuario user) =>
//    {
//        return Results.Ok(user);
//    });

//app.Run();


//public class Usuario
//{
//    public int Id { get; set; }
//    public string Username { get; set; }
//}
