using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using function;

var builder = WebApplication.CreateBuilder(args);

// Add services
Handler.MapServices(builder.Services);

var app = builder.Build();

// Map endpoints
Handler.MapEndpoints(app);

// Start the app
app.Run();

