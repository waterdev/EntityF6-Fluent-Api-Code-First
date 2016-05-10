namespace EntityFrameworkCodeFirstEXAM
{
    using System.Collections.Generic;
    public class User
    {
     
        public int UserID { get; set; }
        public string Name { get; set; }
        public bool IsDebtor { get; set; }
        public virtual Library Library { get; set; }
        public virtual ICollection<Book> BooksOnHands { get; set; }

        public int UserRights { get; set; }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}