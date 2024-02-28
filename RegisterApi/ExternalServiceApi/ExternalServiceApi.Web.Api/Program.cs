using ExternalServiceApi.Core.Contracts;
using ExternalServiceApi.Core.IoC;
using ExternalServiceApi.Infra.ExternalService;
using ExternalServiceApi.Infra.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.RegisterCoreServices();
builder.Services.RegisterInfrastructureServices();
builder.Services.AddSingleton<IServiceTwoIntegrationService, ServiceTwoIntegrationService>();
builder.Services.AddSingleton<IRegisterApiIntegrationService, RegisterApiIntegrationService>();
builder.Services.AddHttpClient();
builder.Services.AddHttpClient("ServiceTwo",
      c => c.BaseAddress = new Uri("https://localhost:7240/"));
builder.Services.AddHttpClient("ServiceTwo",
      c => c.BaseAddress = new Uri("https://localhost:7013/"));
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
