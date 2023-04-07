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

    public DbSet<Approval> Approvals => Set<Approval>();
    public DbSet<Deadline> Deadlines => Set<Deadline>();
    public DbSet<Note> Notes => Set<Note>();
    public DbSet<Package> Packages => Set<Package>();
    public DbSet<Process> Processes => Set<Process>();
    public DbSet<Registration> Registrations => Set<Registration>();
    public DbSet<Requirement> Requirements => Set<Requirement>();
    public DbSet<Resource> Resources => Set<Resource>();
    public DbSet<Review> Reviews => Set<Review>();
    public DbSet<Role> Roles => Set<Role>();
    public DbSet<Token> Tokens => Set<Token>();
    public DbSet<UserRole> UserRoles => Set<UserRole>();
    public DbSet<Workflow> Workflows => Set<Workflow>();

    #endregion

    #region Attachments

    public DbSet<Attachment> Attachments => Set<Attachment>();
    public DbSet<PackageAttachment> PackageAttachments => Set<PackageAttachment>();
    public DbSet<ProcessAttachment> ProcessAttachments => Set<ProcessAttachment>();
    public DbSet<TokenAttachment> TokenAttachments => Set<TokenAttachment>();

    #endregion

    #region Templates

    public DbSet<ApprovalT> ApprovalTs => Set<ApprovalT>();
    public DbSet<DeadlineT> DeadlineTs => Set<DeadlineT>();
    public DbSet<ProcessT> ProcessTs => Set<ProcessT>();
    public DbSet<RequirementT> RequirementTs => Set<RequirementT>();
    public DbSet<ReviewT> ReviewTs => Set<ReviewT>();
    public DbSet<WorkflowT> WorkflowTs => Set<WorkflowT>();

    #endregion

    #endregion

    private IEnumerable<EntityEntry> ChangeTrackerEntities() =>
        ChangeTracker
            .Entries()
            .Where(x => x.Entity is Entity);

    private bool EntitiesChanged() =>
        ChangeTrackerEntities().Any();

    private void CompleteEntity(object? sender, SavingChangesEventArgs e)
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