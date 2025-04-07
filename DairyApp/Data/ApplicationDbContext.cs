using DairyApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DairyApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
       
        {
             
        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry
                {
                    Id = 1,
                    Title = "went Hikking ",
                    Content = "went hikking with srushti...!!",
                    Created = new System.DateTime(2024, 1, 1, 12, 0, 0, 0)
                },

                new DiaryEntry
                {
                    Id = 2,
                    Title = "went shopping",
                    Content = "went shopping with srushti...!!",
                    Created = new System.DateTime(2024, 3, 2, 12, 0, 0, 0)
                },
                    
                new DiaryEntry
                {
                    Id = 3,
                    Title = "went bookreading",
                    Content = "went bookreading with srushti..!!",
                    Created = new System.DateTime(2024, 2, 3, 12, 0, 0, 0)
                }
                );
             
        }
    }
}
