using Microsoft.EntityFrameworkCore;
using SpacePark.Models;

namespace SpacePark.Data
{
    class EFContext : DbContext
    {
        public DbSet<UserRegistrationEntry> Entries { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UserRegistry;");
        }
    }
}
