using Staffing.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Reflection;
using Soc.Api.Schema;

namespace Staffing.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        SavingChanges += CompleteEntity;
    }

    #region Entities

    #region Core

    public DbSet<Deadline> Deadlines { get; set; }
    public DbSet<Note> Notes { get; set; }
    public DbSet<Package> Packages { get; set; }
    public DbSet<Process> Processes { get; set; }
    public DbSet<Registration> Registrations { get; set; }
    public DbSet<Requirement> Requirements { get; set; }
    public DbSet<Resource> Resources { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Token> Tokens { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }
    public DbSet<Workflow> Workflows { get; set; }

    #endregion

    #region Attachments

    public DbSet<Attachment> Attachments { get; set; }
    public DbSet<PackageAttachment> PackageAttachments { get; set; }
    public DbSet<ProcessAttachment> ProcessAttachments { get; set; }
    public DbSet<TokenAttachment> TokenAttachments { get; set; }

    #endregion

    #region Templates

    public DbSet<DeadlineT> DeadlineTs { get; set; }
    public DbSet<ProcessT> ProcessTs { get; set; }
    public DbSet<RequirementT> RequirementTs { get; set; }
    public DbSet<ReviewT> ReviewTs { get; set; }
    public DbSet<WorkflowT> WorkflowTs { get; set; }

    #endregion

    #endregion

    private IEnumerable<EntityEntry> ChangeTrackerEntities() =>
        ChangeTracker
            .Entries()
            .Where(x => x.Entity is Entity);

    private bool EntitiesChanged() =>
        ChangeTrackerEntities().Any();

    private void CompleteEntity(object sender, SavingChangesEventArgs e)
    {
        if (EntitiesChanged())
        {
            var entities = ChangeTrackerEntities()
                .Select(x => x.Entity)
                .Cast<Entity>();

            foreach (Entity entity in entities)
                entity.OnSaving();
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
            Assembly.GetExecutingAssembly()
        );

        modelBuilder
            .Model
            .GetEntityTypes()
            .Where(x => x.BaseType == null)
            .ToList()
            .ForEach(x =>
                modelBuilder
                    .Entity(x.Name)
                    .ToTable(x.DisplayName())
            );
    }
}