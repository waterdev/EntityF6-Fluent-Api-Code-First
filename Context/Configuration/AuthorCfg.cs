using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity;

namespace EntityFrameworkCodeFirstEXAM
{
   public class AuthorCfg:EntityTypeConfiguration<Author>
    {
        public AuthorCfg()
        {
            HasKey(x => x.AuthorID);
            Property(x => x.Name).IsRequired();
        }
    }

    
}
