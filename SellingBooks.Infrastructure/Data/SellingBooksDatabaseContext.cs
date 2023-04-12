using Microsoft.EntityFrameworkCore;
using SellingBooks.Domain.Entities;

namespace SellingBooks.Infrastructure.Data
{
    public class SellingBooksDatabaseContext : DbContext
    {
        public SellingBooksDatabaseContext(DbContextOptions<SellingBooksDatabaseContext> options) 
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<PriceOffer> PriceOffers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>().HasKey( keys => new { keys.BookId, keys.AuthorId});
        }
    }
}
