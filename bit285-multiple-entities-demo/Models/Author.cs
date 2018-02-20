using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IndyBooks.Models
{
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }
        public int BookID { get; set; }

        // TODO: Create at least three  appropriate properties
        public string AuthorName { get; set; }
        public string AuthorAddress { get; set; }


        // TODO: Add Property to represent the entity relationship: "An Author can write many Books"
        public virtual ICollection<Book> AuthorsBooks { get; set; }

    }
}