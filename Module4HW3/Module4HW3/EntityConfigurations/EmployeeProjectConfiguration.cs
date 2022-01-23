using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW3.Entities;

namespace Module4HW3.Configurations;

public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
{
    public void Configure(EntityTypeBuilder<EmployeeProject> builder)
    {
        builder.ToTable("EmployeeProject").HasKey(ep => ep.EmployeeProjectId);
        builder.Property(ep => ep.Rate).HasColumnType("money").IsRequired();
        builder.Property(ep => ep.StartedDate).HasColumnType("datetime2").HasMaxLength(7).IsRequired();
        builder.HasOne(p => p.Project)
            .WithMany(ep => ep.EmployeeProjects)
            .HasForeignKey(p => p.ProjectId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(e => e.Employee)
            .WithMany(ep => ep.EmployeeProjects)
            .HasForeignKey(e => e.EmployeeId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}