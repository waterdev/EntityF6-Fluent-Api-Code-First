namespace EntityFrameworkCodeFirstEXAM
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public  Library Library { get; set; }
        public virtual  ICollection<Author>  Authors { get; set; }
        public virtual User  User { get; set; }
        public DateTime? TimeTaken { get; set; }
        public bool IsAvaible { get; set; } = true;
        public override string ToString()
        {
            return $"{Title}";
        }
    }
}