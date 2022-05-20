
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class HairSalonContext : DbContext
  {
    public DbSet<Stylist> Stylists { get; set; }
    // public DbSet<Category> Categories { get; set; }
    public HairSalonContext(DbContextOptions options) : base(options) { }


  //add category table
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
          optionsBuilder.UseLazyLoadingProxies();
      }
  }  
}