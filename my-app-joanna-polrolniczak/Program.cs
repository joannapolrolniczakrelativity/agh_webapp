var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var configuration = (IConfiguration) app.Services.GetService(typeof(IConfiguration))!;

app.MapGet("/", () => $"Hello World! xd Value: {configuration.GetSection("MyKey").Value} swapped from staging dupa XD");

app.Run();
