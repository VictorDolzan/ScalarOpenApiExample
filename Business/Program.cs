using AspNetCore.Scalar;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "My API",
        Version = "v1",
        Description = "A sample API with Scalar OpenAPI documentation",
        Contact = new OpenApiContact
        {
            Name = "Your Name",
            Email = "your.email@example.com"
        }
    });
});

var app = builder.Build();

// Enable Swagger JSON generation
app.UseSwagger(c =>
{
    c.SerializeAsV2 = false; // Use OpenAPI v3
});

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    c.RoutePrefix = "swagger";
});

app.UseScalar(c => { c.RoutePrefix = "scalar"; });

app.MapControllers();
app.UseHttpsRedirection();
app.Run();