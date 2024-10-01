var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (MinimalApi.DTOs.LoginDTO loginDTO) => {
    if (loginDTO.Email == "amd@teste.com" && loginDTO.Senha == "123456") {
        return Results.Ok("login com sucesso");
    } else {
        return Results.Unauthorized();
    }
});

app.Run();
