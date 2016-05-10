using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EntityFrameworkCodeFirstEXAM
{
     class LibraryCfg:EntityTypeConfiguration<Library>
    {
        public LibraryCfg()
        {
            HasKey(x => x.LibraryID);
            Property(x => x.Name).IsRequired();
        }
    }
}
