using Microsoft.EntityFrameworkCore;
using Datacom.Repository;
using Datacom.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<JobTrackingDbContext>(options =>
{
    options.UseInMemoryDatabase("JobTracking");
});

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddScoped<IJobTrackingService, JobTrackingService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options=>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "Job Tracking API");
    }
    );
}

app.UseAuthorization();

app.MapControllers();

app.Run();
