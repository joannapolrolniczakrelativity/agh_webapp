var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var configuration = (IConfiguration) app.Services.GetService(typeof(IConfiguration))!;

app.MapGet("/", () => $"FAILING TEST! Value: {configuration.GetSection("MyKey").Value}");

app.Run();
