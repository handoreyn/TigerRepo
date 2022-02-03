var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Let's asdasasdsdasdddeploy");

app.Run();
