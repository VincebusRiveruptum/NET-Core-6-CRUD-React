
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using prueba_tecnica_finixgroup.Helpers;

var builder = WebApplication.CreateBuilder(args);

// add services to DI container

var services = builder.Services;
var env = builder.Environment;

// Database context setting
services.AddDbContext<DataContext>();

// CORS for front end requests 
services.AddCors(options => {
    options.AddPolicy("AllowAll",
        builder => {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});


builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if(app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("AllowAll"); 

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
