using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace function;

public static class Handler
{
    // Maps HTTP handlers to paths and methods
    public static void MapEndpoints(WebApplication app)
    {
        app.MapPost("/", async context =>
        {
            // Process incoming request and respond
            var requestBody = await context.Request.ReadFromJsonAsync<dynamic>();
            await context.Response.WriteAsJsonAsync(new { message = "Hello from Knative!", requestBody });
        });
    }

    // Adds additional services (if required)
    public static void MapServices(IServiceCollection services)
    {
        // Add custom services here
    }
}

