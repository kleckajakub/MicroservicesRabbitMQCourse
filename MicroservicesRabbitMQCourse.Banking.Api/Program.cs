using System.Reflection;
using MicroservicesRabbitMQCourse.Banking.Data.Context;
using MicroservicesRabbitMQCourse.Infra.IoC;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => c.SwaggerDoc("v1", new OpenApiInfo {Title = "Banking Microservice", Version = "v1"}));
builder.Services.AddDbContext<BankingDbContext>(options => {
  options.UseSqlServer(builder.Configuration.GetConnectionString("BankingDbConnection"));
});

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

RegisterServices(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
  app.UseSwagger();
  app.UseSwaggerUI(cfg => cfg.SwaggerEndpoint("/swagger/v1/swagger.json", "Banking Microservice V1"));
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

void RegisterServices(IServiceCollection services) {
  DependencyContainer.RegisterServices(services);
}