using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;

namespace BookManagement
{
    public class BookRepositoryMethod
    {
        private IEnumerable<Book> _books;

        public BookRepositoryMethod(IEnumerable<Book> books)
        {
            _books = books;
        }

        public IEnumerable<Book> RetrieveAllBooks()
        {
            return _books;
        }

        public IEnumerable<Book> RetrieveAllOrderByYearDescending()
        {
            return _books.OrderByDescending(book => book.Year);
        }


        public IEnumerable<Book> RetrieveAllOrderByYearAscending()
        {
            return _books.OrderBy(book => book.Year);
        }


        public IEnumerable<Book> RetriveAllOrderByPriceAscending()
        {
            return _books.OrderBy(book => book.Price);
        }

        public IEnumerable<Book> RetriveAllOrderByPriceDescending()
        {
            return _books.OrderByDescending(book => book.Price);
        }

        public Dictionary<Genre, List<Book>> RetriveAllBooksGroupedByGenre()
        {
            return _books.GroupBy(book => book.Genre).ToDictionary(key => key.Key, values => values.ToList());
        }

    }
}
