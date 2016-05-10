using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirstEXAM
{
   public class Library
    {
        public int LibraryID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<User> Users { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
