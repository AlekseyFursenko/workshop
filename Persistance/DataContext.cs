
using Domain.Model.NumbersModel;
using Microsoft.EntityFrameworkCore;

namespace Persistance;

// ORM
public class DataContext : DbContext
{
  public DbSet<NumbersPair> Numbers { get; set; }

  public DataContext(DbContextOptions op)
  : base(op)
  {

  }
}