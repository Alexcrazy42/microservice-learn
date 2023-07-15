using aspnet_docker.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnet_docker.Data
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserContext()
        {
        }

        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connection = "Host=172.20.0.3; Port = 5432; Database=postgres; Username=postgres; Password=changeme;";
                optionsBuilder.UseNpgsql(connection);
                optionsBuilder.EnableSensitiveDataLogging();
            }
        }
    }

}
