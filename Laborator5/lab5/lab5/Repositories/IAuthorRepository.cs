using System;
using System.Collections.Generic;
using System.Text;

namespace lab5.Repositories
{
    public interface IAuthorRepository : IRepository<Author>
    {
        void CreateAuthor(Author author);
        void RemoveAuthor(Guid Id);
    }
}
