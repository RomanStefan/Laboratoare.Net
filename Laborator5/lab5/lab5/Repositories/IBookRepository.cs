using System;
using System.Collections.Generic;
using System.Text;
using lab5.Models;

namespace lab5.Repositories
{
    public interface IBookRepository : IRepository<Book>
    {
        void AddBook(Book book);
        void RemoveBook(Book book);
    }
}
