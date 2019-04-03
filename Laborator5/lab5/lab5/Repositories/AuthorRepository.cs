using System;
using System.Collections.Generic;
using System.Text;

namespace lab5.Repositories
{
    class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(ApplicationContext context) : base(context) { }

        public void CreateAuthor(Author author)
        {
            this.context.Authors.Add(author);
        }

        public void RemoveAuthor(Guid Id)
        {
            var author = this.context.Authors.Find(Id);
            this.context.Authors.Remove(author);
        }

        public ApplicationContext ApplicationContext
        {
            get { return context as ApplicationContext; }
        }
    }
}
