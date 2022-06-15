using VecihleAPI.Data.VehicleData.CarData;
using VehicleAPI.Service.Vehicle.Car;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Add(new ServiceDescriptor(typeof(ICarService), typeof(CarService), ServiceLifetime.Scoped));
builder.Services.Add(new ServiceDescriptor(typeof(ICarData), typeof(CarData), ServiceLifetime.Scoped));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
