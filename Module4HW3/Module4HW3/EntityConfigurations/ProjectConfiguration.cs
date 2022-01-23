using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW3.Entities;

namespace Module4HW3.Configurations;

public class ProjectConfiguration : IEntityTypeConfiguration<Project>
{
    public void Configure(EntityTypeBuilder<Project> builder)
    {
        builder.ToTable("Project").HasKey(p => p.ProjectId);
        builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
        builder.Property(p => p.Budget).HasColumnType("money").IsRequired();
        builder.Property(p => p.StartedDate).HasColumnType("datetime2").HasMaxLength(7).IsRequired();
        builder.HasOne(p => p.Client)
            .WithMany(p => p.Projects)
            .HasForeignKey(p => p.ClientId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasData(
                new Project() { ProjectId = 1, Name = "111", Budget = 100, StartedDate = DateTime.Now.AddDays(-13), ClientId = 1 },
                new Project() { ProjectId = 2, Name = "222", Budget = 200, StartedDate = DateTime.Now.AddDays(-12), ClientId = 2 },
                new Project() { ProjectId = 3, Name = "333", Budget = 300, StartedDate = DateTime.Now.AddDays(-11), ClientId = 3 },
                new Project() { ProjectId = 4, Name = "444", Budget = 400, StartedDate = DateTime.Now.AddDays(-10), ClientId = 4 },
                new Project() { ProjectId = 5, Name = "555", Budget = 500, StartedDate = DateTime.Now.AddDays(-9), ClientId = 5 });
    }
}