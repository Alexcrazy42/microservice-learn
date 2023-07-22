using aspnet_docker.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnet_docker.Data
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        

        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
            
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        string connection = "Server=postgres_db; Port=5432; User id=postgres; password=123; database=users;";
        //        optionsBuilder.UseNpgsql(connection);
        //        optionsBuilder.EnableSensitiveDataLogging();
        //    }
        //}
    }

}
