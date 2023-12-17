
using Domain.Model.Contacts;
using Domain.Model.NumbersModel;
using Microsoft.EntityFrameworkCore;

namespace Persistance;

// ORM
public class DataContext : DbContext
{
  public DbSet<NumbersPair> Numbers { get; set; }

  public DbSet<UserContact> Contacts { get; set; }
  public DbSet<Telephone> UserTelephones { get; set; }

  public DataContext(DbContextOptions op)
  : base(op)
  {
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    // one to many
    modelBuilder.Entity<UserContact>()
    .HasMany(e => e.AllTelephones)
    .WithOne(c => c.Username)
    .HasForeignKey(c => c.UsernameId)
    .OnDelete(DeleteBehavior.Cascade);

    modelBuilder.Entity<Telephone>()
    .HasIndex(c => c.UsernameId);

  }
}