using Microsoft.EntityFrameworkCore;
using Wipro_API_CodeFirstApproach.Entity_Framework;
using Wipro_API_CodeFirstApproach.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(tm => tm.UseSqlServer(builder.Configuration.GetConnectionString("VehicleConnection")));
builder.Services.AddTransient<IVehicleService, VehicleService>();
builder.Services.AddTransient<ICustomerService, CustomerService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
