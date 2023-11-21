using Day_6_efcore.Models;
using Microsoft.EntityFrameworkCore;

namespace Day_6_efcore.Context;

public class BaseDbContext : DbContext
{

    public BaseDbContext(DbContextOptions options) : base(options)
    {
    }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server = (localdb)\\MSSQLLocalDB; Database = Sportss_Db; Trusted_Connection=true");
    }
    public  DbSet<Player> Players{ get; set; }
}

