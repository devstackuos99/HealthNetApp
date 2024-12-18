using BDManager.DAL.Entities;
using HealthNet.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HealthNet.DAL
{
    public class HealthNetContext : IdentityDbContext<SystemUser, Role, int, IdentityUserClaim<int>, UserRole,
        IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public HealthNetContext(DbContextOptions<HealthNetContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<SystemUser>().ToTable("Users")
                    .HasMany(e => e.Roles)
                    .WithMany(e => e.Users)
                    .UsingEntity<UserRole>();

            builder.Entity<Role>().ToTable("Roles");

            builder.Entity<UserRole>()
                .ToTable("UserRoles")
                .HasKey(x => new { x.UserId, x.RoleId });

            builder.Entity<IdentityUserClaim<int>>(entity => { entity.ToTable("UserClaims"); });

            builder.Entity<IdentityUserLogin<int>>(entity =>
            {
                entity.ToTable("UserLogins");
                entity.HasKey(x => new { x.LoginProvider, x.ProviderKey });
            });

            builder.Entity<IdentityUserToken<int>>(entity =>
            {
                entity.ToTable("UserTokens");
                entity.HasKey(x => new { x.UserId, x.LoginProvider, x.Name });
            });

            builder.Entity<IdentityRoleClaim<int>>(entity => { entity.ToTable("RoleClaims"); });

            builder.Entity<Permission>()
                    .HasMany(e => e.Users)
                    .WithMany(e => e.Permissions)
                    .UsingEntity<UserPermission>();

            SeedData.Seed(builder);

        }

        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SystemUser> SystemUsers { get; set; }
        public DbSet<UserPermission> userPermissions { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Earning> Earnings { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientVisitByGender> PatientVisitByGender { get; set; }
        
        
    }
    
}
