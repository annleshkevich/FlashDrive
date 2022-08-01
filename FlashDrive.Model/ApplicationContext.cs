using Microsoft.EntityFrameworkCore;
using FlashDrive.Model.DatabaseModels;

namespace FlashDrive.Model
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Flash_Drive> FlashDrives { get; set; } = null!;
    }
}
