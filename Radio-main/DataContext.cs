using Microsoft.EntityFrameworkCore;


namespace RadioList_v._1._0
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = databaseStations.db");
        }

        public DbSet<Station> Stations { get; set; }
    }
}
