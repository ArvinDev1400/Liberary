using Microsoft.EntityFrameworkCore;
using Persistent.Context;

ApplicationDbContext dbContext = new ApplicationDbContext();


dbContext.Members.Where(p => p.Id == 10)
    .Include(p => p.LoanedBooks).ToList();

dbContext.Books.Where(p => p.Id == 10)
    .Include(p => p.Image)
    .Include(p => p.LoanedBooks)
    .Select(p => new
    {
        p.Id ,
        p.Image
    })
    .ToList();
//dbContext.Database.EnsureDeleted();
//dbContext.Database.EnsureCreated();