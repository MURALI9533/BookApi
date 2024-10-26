var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy("Mycorcs", builder =>{
        builder.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
    });
});
var app = builder.Build();
app.UseCors("Mycorcs");

app.MapControllers();
//app.MapGet("/", () => "Hello World!");
app.MapGet("/", () => { return Results.Redirect("/api/books"); });

app.Run();
