using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW3.Entities;

namespace Module4HW3.Configurations;

public class OfficeConfiguration : IEntityTypeConfiguration<Office>
{
    public void Configure(EntityTypeBuilder<Office> builder)
    {
        builder.ToTable("Office").HasKey(o => o.OfficeId);
        builder.Property(o => o.Title).HasMaxLength(100).IsRequired();
        builder.Property(o => o.Location).HasMaxLength(100).IsRequired();
    }
}