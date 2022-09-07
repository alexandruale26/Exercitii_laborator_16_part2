using Exercitii_laborator_16_part2.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercitii_laborator_16_part2.Data
{
    public class AutovehiclesContextDB : DbContext
    {
        public DbSet<Autovehicle> Autovehicles { get; set; } = null!;
        public DbSet<Manufacturer> Manufacturers { get; set; } = null!;


        public AutovehiclesContextDB() : base()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Alexandru\\source\\repos\\Exercitii_laborator_16_part2\\Exercitii_laborator_16_part2\\AutovehiclesDB.mdf;Integrated Security=True");
        }
    }
}
