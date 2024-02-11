using CarPrice_DataAccess.Repositories;
using CarPrice_DataAccess.Repositories.Interfaces;
using CarPrice_DataAccess.Services;
using CarPrice_DataAccess.Services.Interfaces;
using CarPrice_Models.Dtos;
using CarPrice_Server.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Add database connection
builder.Services.AddDbContextPool<CarPriceDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString")));
builder.Services.AddScoped<ICarRepository, CarRepository>();
builder.Services.AddScoped<IGetRecordsQueryBuilderService, GetRecordsQueryBuilderService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors(policy => policy.WithOrigins("http://localhost:5153", "https://localhost:5153").AllowAnyMethod());

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();

