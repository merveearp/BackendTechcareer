using Day_6_efcore.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Day_6_efcore.Context;

public class BaseDbContext : DbContext
{

    public BaseDbContext(DbContextOptions options) : base(options)
    {
        Database.EnsureCreated();
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    public  DbSet<Player> Players{ get; set; }
    public DbSet<Team> Teams  { get; set; }
    public  DbSet<Outfit> Outfits { get; set; }
    public DbSet<Branch> Branches  { get; set; }
}

