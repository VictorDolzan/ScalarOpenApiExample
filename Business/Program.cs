using AspNetCore.Scalar;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.EnableAnnotations();
    c.ExampleFilters(); 
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "💻Scalar Open API",
        Version = "v1",
        Description = "A sample API with Scalar OpenAPI documentation",
        Contact = new OpenApiContact
        {
            Name = "Victor Dolsan",
            Email = "victorddf5@gmail.com",
        }
    });
    
    var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

builder.Services.AddSwaggerExamplesFromAssemblyOf<Program>();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseSwagger();

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Scalar Open API V1");
    c.RoutePrefix = "swagger"; // serve Swagger UI at /swagger
});

app.MapControllers();
app.UseScalar(options =>
{
    options.DocumentTitle = "💻Scalar Open API";
    options.RoutePrefix = "scalar";
    //switch themes
    // options.UseTheme(Theme.Default); 
    options.UseTheme(Theme.Kepler);
    // options.UseTheme(Theme.Moon);
});

app.Run();