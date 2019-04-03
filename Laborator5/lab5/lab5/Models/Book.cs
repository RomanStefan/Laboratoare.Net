using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace lab5.Models
{
    [Table("Books")]
    public class Book
    {
        public Guid Id { get; private set; }

        [Required]
        [StringLength(100, MinimumLength = 50)]
        public string Title { get; private set; }

        public Author Author { get; private set; }

        private Book()
        {

        }

        public static Book Create(string title)
        {
            return new Book
            {
                Id = Guid.NewGuid(),
                Title = title,
            };
        }
    }
}
