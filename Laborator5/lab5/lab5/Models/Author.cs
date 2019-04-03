using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using lab5.Models;

namespace lab5
{
    [Table("Authors")]
    public class Author
    {
        public Guid Id { get; private set; }

        [Required]
        [StringLength(100, MinimumLength = 50)]
        public string FirstName { get; private set; }

        [Required]
        [StringLength(150)]
        public string LastName { get; private set; }

        public ICollection<Book> Books;

        private Author()
        {

        }

        public static Author Create(string firstname, string lastname)
        {
            return new Author
            {
                Id = Guid.NewGuid(),
                FirstName = firstname,
                LastName = lastname
            };
        }


    }
}
