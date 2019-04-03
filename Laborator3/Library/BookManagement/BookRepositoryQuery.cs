using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;

namespace BookManagement 
{
    public class BookRepositoryQuery
    {
        private IEnumerable<Book> _books;

        public BookRepositoryQuery(IEnumerable<Book> books)
        {
            _books = books;
        }

        public IEnumerable<Book> RetrieveAllBooks()
        {
            return from book in _books select book;
        }

        public IEnumerable<Book> RetrieveAllOrderByYearDescending()
        {
            return from book in _books
                orderby book.Year descending
                select book;
        }

        public IEnumerable<Book> RetriveAllOrderByYearAscending()
        {
            return from book in _books
                orderby book.Year ascending
                select book;
        }

        public IEnumerable<Book> RetriveAllOrderByPriceAscending()
        {
            return from book in _books
                orderby book.Price ascending
                select book;
        }

        public IEnumerable<Book> RetriveAllOrderByPriceDescending()
        {
            return from book in _books
                orderby book.Price descending 
                select book;
        }

        public IDictionary<Genre, List<Book>> RetriveAllBooksGroupedByGenre()
        {
            var booksByGenres = from book in _books
                group book by book.Genre
                into dict
                select new
                {
                    Genre = dict.Key,
                    Books = dict.ToList()
                };
            return booksByGenres.ToDictionary(genreKey => genreKey.Genre, books => books.Books);
        }
       

    }
}
