using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistent.Context;

public class ApplicationDbContext : DbContext
{

    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=.;Initial catalog=Liberary;Integrated Security=True;TrustServerCertificate=True");
    }
}
