using System.Reflection;
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
using APPOINTMENT_SERVICE_API.Main.Root.Core.Database.Schemas.Entities;
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

    public DatabaseConfig(DbContextOptions<DatabaseConfig> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Many-to-Many: User ↔ Role
        modelBuilder.Entity<UserEntity>()
            .HasMany(u => u.Roles)
            .WithMany(r => r.Users)
            .UsingEntity(j => j.ToTable("User_Roles"));

        // Many-to-Many: User ↔ Company
        modelBuilder.Entity<UserEntity>()
            .HasMany(u => u.Companies)
            .WithMany(c => c.Users)
            .UsingEntity(j => j.ToTable("User_Companies"));

        // Many-to-Many: Employee ↔ WorkSchedule
        modelBuilder.Entity<EmployeeEntity>()
            .HasMany(e => e.WorkSchedules)
            .WithMany(ws => ws.Employees)
            .UsingEntity(j => j.ToTable("Employee_WorkSchedules"));

        // Global soft-delete query filter for all entities derived from BaseEntity
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            if (typeof(BaseEntity).IsAssignableFrom(entityType.ClrType))
            {
                var method = typeof(DatabaseConfig)
                    .GetMethod(nameof(SetSoftDeleteFilter), BindingFlags.NonPublic | BindingFlags.Static)
                    ?.MakeGenericMethod(entityType.ClrType);

                method?.Invoke(null, new object[] { modelBuilder });
            }
        }
    }

    private static void SetSoftDeleteFilter<TEntity>(ModelBuilder builder) where TEntity : BaseEntity
    {
        builder.Entity<TEntity>().HasQueryFilter(e => e.DeletedOn == null);
    }

    public override int SaveChanges()
    {
        UpdateTimestampsAndSoftDelete();
        return base.SaveChanges();
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        UpdateTimestampsAndSoftDelete();
        return await base.SaveChangesAsync(cancellationToken);
    }

    private void UpdateTimestampsAndSoftDelete()
    {
        foreach (var entry in ChangeTracker.Entries<BaseEntity>())
        {
            if (entry.State == EntityState.Deleted)
            {
                // Soft delete: mark DeletedOn and prevent actual delete
                entry.State = EntityState.Modified;
                entry.Entity.DeletedOn = DateTime.UtcNow;
            }
            else if (entry.State == EntityState.Modified)
            {
                // Update UpdatedOn automatically
                entry.Entity.UpdatedOn = DateTime.UtcNow;
            }
            else if (entry.State == EntityState.Added)
            {
                // Set timestamps on creation
                entry.Entity.CreatedOn = DateTime.UtcNow;
                entry.Entity.UpdatedOn = DateTime.UtcNow;
            }
        }
    }
}