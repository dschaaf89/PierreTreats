using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PierreTreats.Models
{
  public class PierreTreatsContext : IdentityDbContext<ApplicationUser>
  {


    public PierreTreatsContext(DbContextOptions options) : base(options) { }  
  }
}