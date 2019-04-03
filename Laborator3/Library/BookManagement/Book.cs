using System;

namespace BookManagement
{
    public class Book
    {
        private Book ()
        {

        }

        public Guid Id { get; private set; }

        public string Title { get; private set; }

        public int Year { get; private set; }

        public double Price { get; private set; }

        public Genre Genre { get; private set; }

        public static Book Create(string title, int year, double price, Genre genre)
        {
            return new Book()
            {
                Id = Guid.NewGuid(),
                Title = title,
                Year = year,
                Price = price,
                Genre = genre
            };
        }
    }
}
