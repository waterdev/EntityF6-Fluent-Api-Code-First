namespace EntityFrameworkCodeFirstEXAM
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LibraryContexModel : DbContext
    {
        public DbSet<Library> Libraries { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        public LibraryContexModel()
            : base("name=LibraryContexModel")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new BookCfg());
            modelBuilder.Configurations.Add(new LibraryCfg());
            modelBuilder.Configurations.Add(new UserCfg());
            modelBuilder.Configurations.Add(new AuthorCfg());
        }
    }


}