using System;
using System.Collections.Generic;
using System.Text;
using lab5.Models;

namespace lab5.Repositories
{
    class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(ApplicationContext context) : base(context) { }

        public void AddBook(Book book)
        {
            this.context.Books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            this.context.Books.Remove(book);
        }

        public ApplicationContext ApplicationContext
        {
            get { return context as ApplicationContext; }
        }
    }
}
