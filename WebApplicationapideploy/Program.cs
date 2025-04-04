var builder = WebApplication.CreateBuilder(args);

// Register controller services
builder.Services.AddControllers();

var app = builder.Build();

app.MapGet("/", () => "Hello, World!"); // Test route

app.UseRouting();

// Ensure controller endpoints are available
app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

app.Run();
