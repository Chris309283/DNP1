using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Persistence;

public class LibraryContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Genre> Genres { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
    {
        optionBuilder.UseSqlite(@"Data Source = C:\Users\Christopher\RiderProjects\DNP1\Library\Library.db");
    }
}