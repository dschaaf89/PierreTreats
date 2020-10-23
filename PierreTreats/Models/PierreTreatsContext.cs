using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PierreTreats.Models
{
  public class PierreTreatsContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Treat> Treats { get; set; }
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<TreatFlavor> TreatFlavors { get; set; }

    public PierreTreatsContext(DbContextOptions options) : base(options) { }  
  }
}