using Domain.Entities;
using Infrastructure.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Persistent.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Member> Members { get; set; }

    public DbSet<LoanedBook> LoanedBooks { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BookConfiguration());
    }
}
