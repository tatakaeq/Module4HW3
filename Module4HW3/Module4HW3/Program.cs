using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Module4HW3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            var connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;

            using (var db = new ApplicationDbContext(options))
            {
                db.SaveChanges();
            }
        }
    }
}