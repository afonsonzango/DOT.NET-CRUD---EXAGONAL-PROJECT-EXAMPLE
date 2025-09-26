using APPOINTMENT_SERVICE_API.Main.Features.Address.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Features.Booking.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Features.Client.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Features.Company.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Features.Contact.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Features.Employee.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Features.Role.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Features.Service.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Features.User.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Features.WorkSchedule.infrastructure.entity;
using Microsoft.EntityFrameworkCore;

namespace APPOINTMENT_SERVICE_API.Main.Root.Core.Database.Connection;

public class DatabaseConfig : DbContext
{
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<RoleEntity> Roles { get; set; }
    public DbSet<CompanyEntity> Companies { get; set; }
    public DbSet<EmployeeEntity> Employees { get; set; }
    public DbSet<WorkScheduleEntity> WorkSchedules { get; set; }
    public DbSet<ServiceEntity> Services { get; set; }
    public DbSet<ClientEntity> Clients { get; set; }
    public DbSet<AddressEntity> Addresses { get; set; }
    public DbSet<ContactEntity> Contacts { get; set; }
    public DbSet<BookingEntity> Bookings { get; set; }
 
    public DatabaseConfig(DbContextOptions<DatabaseConfig> options) : base(options)
    {
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // User ↔ Role (N:N)
        modelBuilder.Entity<UserEntity>()
            .HasMany(u => u.Roles)
            .WithMany(r => r.Users)
            .UsingEntity(j => j.ToTable("User_Roles"));

        // User ↔ Company (N:N)
        modelBuilder.Entity<UserEntity>()
            .HasMany(u => u.Companies)
            .WithMany(c => c.Users)
            .UsingEntity(j => j.ToTable("User_Companies"));

        // Employee ↔ WorkSchedule (N:N)
        modelBuilder.Entity<EmployeeEntity>()
            .HasMany(e => e.WorkSchedules)
            .WithMany(ws => ws.Employees)
            .UsingEntity(j => j.ToTable("Employee_WorkSchedules"));
    }
}