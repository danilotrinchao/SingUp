using RegisterApi.Core.Contracts;
using RegisterApi.Core.IoC;
using RegisterApi.Infra.Data.ExternalService;
using RegisterApi.Infra.Data.Utils;
using RegisterApi.Infrastructure.IoC;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.RegisterCoreServices();
builder.Services.RegisterInfrastructureServices();
builder.Services.AddSingleton<IServiceTwoIntegrationService, ServiceTwoIntegrationService>();
builder.Services.AddHttpClient();
builder.Services.AddHttpClient("ServiceTwo",
      c => c.BaseAddress = new Uri("https://localhost:7240/"));
SerilogExtensions.AddSerilogApi(builder.Configuration);
builder.Host.UseSerilog(Log.Logger);


var app = builder.Build();
var serviceProvider = app.Services;
app.UseMiddleware<RequestSerilLogMiddleware>();
app.UseMiddleware<ErrorHandlingMiddleware>();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
