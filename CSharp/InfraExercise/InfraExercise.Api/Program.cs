using InfraExercise.Api;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHealthChecks().AddCheck<MyLivenessCheck>("liveness_check");
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapHealthChecks("/q/health", new HealthCheckOptions
{
    Predicate = check => check.Name == "liveness_check"
});


app.MapGet("/hello", () => "Hello from InfraExercise!");

app.Run();