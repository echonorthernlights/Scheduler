using Scheduler.Controllers;
using Scheduler.Services;
using Scheduler.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IService, Service>();
//builder.Services.AddScoped<IControllerFactoryService, ControllerFactoryService>();
builder.Services.AddScoped<HomeController>();

// Register the ScheduledService as a background service
builder.Services.AddHostedService<ScheduledService>();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
