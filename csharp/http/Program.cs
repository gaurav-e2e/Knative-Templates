using Function;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var function = new Function.Function();

// Map the main function endpoint
app.MapPost("/", async (HttpRequest request) => await Task.FromResult(function.Handle(request)));
app.MapGet("/", async (HttpRequest request) => await Task.FromResult(function.Handle(request)));

// Health check endpoints
app.MapGet("/health/liveness", () => Results.Ok());
app.MapGet("/health/readiness", () => Results.Ok());

app.Run("http://0.0.0.0:8080");
