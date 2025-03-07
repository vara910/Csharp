using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);

// Enable CORS to allow requests from React frontend
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:3000") // React frontend URL
                                .AllowAnyHeader()
                                .AllowAnyMethod();
                      });
});

// Add controllers
builder.Services.AddControllers();

var app = builder.Build();

// Enable CORS
app.UseCors(MyAllowSpecificOrigins);

// Enable routing
app.UseRouting();

// Enable authorization (optional)
app.UseAuthorization();

// Map controllers
app.MapControllers();

// Run the app
app.Run();
