using Microsoft.EntityFrameworkCore;
using Wipro_AutoMapper_29_08_2024.EntityFrameWork;
using Wipro_AutoMapper_29_08_2024.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<WiproDfa29082024Context>(tm => tm.UseSqlServer(builder.Configuration.GetConnectionString("CountryConnection")));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddTransient<IStateRepository, StateRepository>();
builder.Services.AddTransient<ICountryRepository, CountryRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
