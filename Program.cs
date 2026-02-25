var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.AddDebug();

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/pasha", (ILogger<Program> logger) =>
{
    logger.LogInformation("Hello Pasha Siibiryak!!!");
    return "Hello Pasha Siibiryak!!!";
});
// .WithName("GetWeatherForecast");

app.MapGet("/test", (ILogger<Program> logger) =>
{
    logger.LogInformation("Hello World!!!");
    return "Hello World!!!";
});
    // .WithName("getHelloWorld");

app.Run();
