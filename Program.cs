using APPOINTMENT_SERVICE_API.Main.Features.Address.domain.mappers;
using APPOINTMENT_SERVICE_API.Main.Features.Booking.domain.mappers;
using APPOINTMENT_SERVICE_API.Main.Features.Client.domain.mappers;
using APPOINTMENT_SERVICE_API.Main.Features.Company.domain.mappers;
using APPOINTMENT_SERVICE_API.Main.Features.Contact.domain.mappers;
using APPOINTMENT_SERVICE_API.Main.Features.Employee.domain.mappers;
using APPOINTMENT_SERVICE_API.Main.Features.Role.domain.mappers;
using APPOINTMENT_SERVICE_API.Main.Features.Service.domain.mappers;
using APPOINTMENT_SERVICE_API.Main.Features.User.adapters.rest.exceptions;
using APPOINTMENT_SERVICE_API.Main.Features.User.application.services;
using APPOINTMENT_SERVICE_API.Main.Features.User.domain.mappers;
using APPOINTMENT_SERVICE_API.Main.Features.User.infrastructure.repository;
using APPOINTMENT_SERVICE_API.Main.Features.WorkSchedule.domain.mappers;
using APPOINTMENT_SERVICE_API.Main.Root.Core.Database.Connection;
using APPOINTMENT_SERVICE_API.Main.Root.Core.Exceptions;
using APPOINTMENT_SERVICE_API.Main.Root.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// =============================================
// Database connection (PostgreSQL)
// =============================================
builder.Services.AddDbContext<DatabaseConfig>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// =============================================
// AutoMapper setup (registers all profiles in the assembly)
// =============================================
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// =============================================
// Register custom mappers (if you need them explicitly)
// =============================================
builder.Services.AddScoped<UserMapper>();
builder.Services.AddScoped<AddressMapper>();
builder.Services.AddScoped<BookingMapper>();
builder.Services.AddScoped<ClientMapper>();
builder.Services.AddScoped<CompanyMapper>();
builder.Services.AddScoped<ContactMapper>();
builder.Services.AddScoped<EmployeeMapper>();
builder.Services.AddScoped<RoleMapper>();
builder.Services.AddScoped<ServiceMapper>();
builder.Services.AddScoped<WorkScheduleMapper>();

// =============================================
// Add controllers + Swagger/OpenAPI
// =============================================
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ============================================
// REGISTER USER SERVICES
// ============================================
builder.Services.AddScoped<IUserServiceInPort, UserServices>();
builder.Services.AddScoped<IUserRepositoryOutPort, UserRepository>();


builder.Services.AddControllers(options =>
{
    // SINGULAR FILTERS
    options.Filters.Add<UserConflictExceptionFilter>();
    options.Filters.Add<UserNotFoundExceptionFilter>();
    options.Filters.Add<UserNotFoundExceptionFilter>();
});

builder.Services.ConfigureCustomValidation();

var app = builder.Build();

// =============================================
// Configure HTTP request pipeline
// =============================================
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers(); 

// =============================================
// Test endpoint (can be removed later)
// =============================================
var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild",
    "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.Run();

// =============================================
// Record for weather forecast (test only)
// =============================================
record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
