namespace Function
{
    public class Function
    {
        public IResult Handle(HttpRequest request)
        {
            // Get query parameters or body content as needed
            // Example: var name = request.Query["name"].ToString() ?? "World";
            
            // Return a simple JSON response
            return Results.Json(new { 
                message = "Hello from C# Function!",
                timestamp = DateTime.UtcNow
            });
        }
    }
}
