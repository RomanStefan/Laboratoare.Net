using System;
using System.Collections.Generic;
using System.Text;
using lab5.Repositories;
namespace lab5.Queries
{
    public interface IUnitOfWork : IDisposable
    {
        IBookRepository Books { get; }
        IAuthorRepository Authors { get; }
        int Complete();
    }
}
