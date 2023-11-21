using Day_6_efcore.Context;
using Day_6_efcore.Repositories.Abstract;
using Day_6_efcore.Repositories.Concrete;
using Day_6_efcore.Services.Concrete;
using System.Reflection;
using Day_6_efcore.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddDbContext<BaseDbContext>();
//
//
builder.Services.AddScoped<IPlayerRepository,PlayerRepository>();
builder.Services.AddScoped<PlayerService>();

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
