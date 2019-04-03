using System;
using System.Collections.Generic;
using System.Text;
using lab5.Repositories;

namespace lab5.Queries
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;

       

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            Books = new BookRepository(_context);
            Authors = new AuthorRepository(_context);
        }

        public IBookRepository Books { get; private set; }
        public IAuthorRepository Authors { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose(); 
        }
    }
}
