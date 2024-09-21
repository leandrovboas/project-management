using Microsoft.EntityFrameworkCore;
using ProjectManagement.Core.Entities;

namespace ProjectManagement.Infra.Configurations;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }


    //public override int SaveChanges()
    //{
    //    foreach (var entity in ChangeTracker.Entries<Project>())
    //    {
    //        if (entity.State == EntityState.Deleted)
    //        {
    //            entity.State = EntityState.Modified;
    //            entity.Entity.ChangeIsDeleted(true);
    //        }
    //    }
    //    return base.SaveChanges();
    //}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        new DbInitializer(modelBuilder).Seed();
        //modelBuilder.Entity<Project>().HasQueryFilter(P => !P.IsDeleted);
    }
}
