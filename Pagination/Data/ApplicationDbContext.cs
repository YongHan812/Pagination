using Microsoft.EntityFrameworkCore;

namespace Pagination.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Demo> Demo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Demo>().HasData(
                new Demo { Id = 1, Name = "Chan Sin Yow" },
                new Demo { Id = 2, Name = "Yong Han" },
                new Demo { Id = 3, Name = "Amelia" },
                new Demo { Id = 4, Name = "Amy" },
                new Demo { Id = 5, Name = "Angela" },
                new Demo { Id = 6, Name = "Anna" },
                new Demo { Id = 7, Name = "Anne" },
                new Demo { Id = 8, Name = "Bella" },
                new Demo { Id = 9, Name = "Belle" },
                new Demo { Id = 10, Name = "Carol" },
                new Demo { Id = 11, Name = "Chloe" },
                new Demo { Id = 12, Name = "Claire" },
                new Demo { Id = 13, Name = "Diana" },
                new Demo { Id = 14, Name = "Ella" },
                new Demo { Id = 15, Name = "Emily" },
                new Demo { Id = 16, Name = "Emma" },
                new Demo { Id = 17, Name = "Sam" },
                new Demo { Id = 18, Name = "Tony Stark" },
                new Demo { Id = 19, Name = "Peter Parker" },
                new Demo { Id = 20, Name = "Steve" },
                new Demo { Id = 21, Name = "Steve" },
                new Demo { Id = 22, Name = "Steve" },
                new Demo { Id = 23, Name = "Steve" },
                new Demo { Id = 24, Name = "Steve" },
                new Demo { Id = 25, Name = "Steve" },
                new Demo { Id = 26, Name = "Sos" },
                new Demo { Id = 27, Name = "Sos" },
                new Demo { Id = 28, Name = "Sos" },
                new Demo { Id = 29, Name = "Sos" },
                new Demo { Id = 30, Name = "Sos" },
                new Demo { Id = 31, Name = "Covid" },
                new Demo { Id = 32, Name = "Covid" },
                new Demo { Id = 33, Name = "Covid" },
                new Demo { Id = 34, Name = "Covid" },
                new Demo { Id = 35, Name = "Covid" },
                new Demo { Id = 36, Name = "Covid" }
            );
        }
    }
}
