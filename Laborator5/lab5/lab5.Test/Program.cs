using System;
using lab5;
using lab5.Queries;
using lab5.Repositories;


namespace lab5.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var unitOfWork = new UnitOfWork(new ApplicationContext()))
            {
                var author1 = Author.Create("Iion", "Sebi");
                unitOfWork.Authors.Add(author1);

                unitOfWork.Complete();
            }
        }
    }
}
