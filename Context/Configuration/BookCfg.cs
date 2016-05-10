using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirstEXAM
{
  public class BookCfg:EntityTypeConfiguration<Book>
    {
        public BookCfg()
        {
            HasKey(x => x.BookID);
            Property(x => x.Title).IsRequired().HasMaxLength(30);
            Property(x => x.TimeTaken).HasColumnType("datetime2");
            Property(x => x.IsAvaible).IsRequired();
            Property(x => x.TimeTaken).IsOptional();
        }
    }
}
