namespace EntityFrameworkCodeFirstEXAM
{ 
    using System.Collections.Generic;
    
    public class Author
    {
        
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}