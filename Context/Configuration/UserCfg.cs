using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity;

namespace EntityFrameworkCodeFirstEXAM
{
    class UserCfg:EntityTypeConfiguration<User>
    {
        public UserCfg()
        {
            HasKey(x => x.UserID);
            Property(x => x.Name).IsRequired();                   
        }
    }
}
