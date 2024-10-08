using CoffeeTracker.WebAPI.Data;
using CoffeeTracker.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<CoffeeTrackerContext>(options =>
{
  options.UseNpgsql(builder.Configuration.GetConnectionString("Default"));
});
builder.Services.AddScoped<ICoffeeLogsRepository, CoffeeLogsRepository>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
