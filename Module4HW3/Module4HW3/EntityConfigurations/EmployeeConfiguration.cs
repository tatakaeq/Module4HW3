using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW3.Entities;

namespace Module4HW3.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("Employee").HasKey(e => e.EmployeeId);
        builder.Property(e => e.FirstName).HasMaxLength(50).IsRequired();
        builder.Property(e => e.LastName).HasMaxLength(50).IsRequired();
        builder.Property(e => e.HiredDate).HasColumnType("datetime2").HasMaxLength(7).IsRequired();
        builder.Property(e => e.DateOfBirth).HasColumnType("date");
        builder.HasOne(o => o.Office)
            .WithMany(e => e.Employees)
            .HasForeignKey(o => o.OfficeId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(t => t.Title)
            .WithMany(e => e.Employees)
            .HasForeignKey(t => t.TitleId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}