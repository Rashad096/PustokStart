using Microsoft.EntityFrameworkCore;
using Pustok_Start.Models;

namespace Pustok_Start.DAL
{
    public class PustokDbContext:DbContext
    {
        public PustokDbContext(DbContextOptions<PustokDbContext> options) : base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Tag>Tags { get; set; }
        public DbSet<BookTag> BookTags { get; set; }
        public DbSet<BookImage> BookImages {get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BookTag>(x => x.HasKey(bt => new { bt.BookId, bt.TagId }));
            //modelBuilder.Entity<BookTag>().HasOne(x => x.Book).WithMany(x => x.BookTags);
        }

    }
}
