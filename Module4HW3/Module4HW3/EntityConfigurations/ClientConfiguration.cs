using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW3.Entities;

namespace Module4HW3.EntityConfigurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client").HasKey(c => c.ClientId);
            builder.Property(c => c.Title).HasMaxLength(100).IsRequired();
            builder.Property(c => c.Email).HasMaxLength(100).IsRequired();
            builder.Property(c => c.PhoneNumber).HasMaxLength(15).IsRequired();
            builder.Property(c => c.Country).HasMaxLength(20).IsRequired();

            builder.HasData(
                new Client() { ClientId = 1, Email = "111111@1111.com", Title = "1", PhoneNumber = "111111111111", Country = "11111" },
                new Client() { ClientId = 2, Email = "222222@2222.com", Title = "2", PhoneNumber = "222222222222", Country = "22222" },
                new Client() { ClientId = 3, Email = "333333@3333.com", Title = "3", PhoneNumber = "333333333333", Country = "33333" },
                new Client() { ClientId = 4, Email = "444444@4444.com", Title = "4", PhoneNumber = "444444444444", Country = "44444" },
                new Client() { ClientId = 5, Email = "555555@5555.com", Title = "5", PhoneNumber = "555555555555", Country = "55555" });
        }
    }
}
