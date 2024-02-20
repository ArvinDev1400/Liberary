using Microsoft.EntityFrameworkCore;
using Persistent.Context;

ApplicationDbContext dbContext = new ApplicationDbContext();

dbContext.Books.Include(p => p.Image).ToList();



dbContext.Database.EnsureDeleted();
dbContext.Database.EnsureCreated();