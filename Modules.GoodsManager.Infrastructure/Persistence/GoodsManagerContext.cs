using Microsoft.EntityFrameworkCore;
using Modules.GoodsManager.Entities;

namespace Modules.GoodsManager.Infrastructure.Persistence;

internal class GoodsManagerContext : DbContext
{
    public DbSet<Category> Categories { get; set; }

    public GoodsManagerContext()
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}