using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Provider.Polly;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add config file for Ocelot

IConfiguration confg = new ConfigurationBuilder()
    .AddJsonFile("ocelotexample.json")
    .Build();

builder.Services.AddOcelot(confg).AddPolly();
builder.Services.AddSwaggerForOcelot(confg);
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerForOcelotUI();
    //app.UseSwaggerUI();
}

app.UseOcelot();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
