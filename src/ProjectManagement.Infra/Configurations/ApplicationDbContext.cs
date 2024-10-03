using Microsoft.EntityFrameworkCore;
using ProjectManagement.Core.TableModels;

namespace ProjectManagement.Infra.Configurations;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<UserModel> Users { get; set; }
    public virtual DbSet<ProjectModel> Project { get; set; }
    public virtual DbSet<UserModel> WorkItem { get; set; }


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

        modelBuilder.Entity<WorkItemsModel>()
            .HasOne<ProjectModel>(p => p.Project)
            .WithMany(w => w.WorkItems)
            .HasForeignKey(w => w.ProjectId);

        new DbInitializer(modelBuilder).Seed();
        //modelBuilder.Entity<Project>().HasQueryFilter(P => !P.IsDeleted);
    }
}
