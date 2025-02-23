using Microsoft.EntityFrameworkCore;
using Team_3_mueseum.Model;


namespace Team_3_mueseum.Data{
    public class AppDbContext : DbContext{

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 

        }
        public DbSet<user> UserTable { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<user>()
                .ToTable("Users"); 
        }
    }
    
    
}