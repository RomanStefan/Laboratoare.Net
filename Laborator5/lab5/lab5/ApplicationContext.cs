using System;
using System.Collections.Generic;
using System.Text;
using lab5.Models;
using Microsoft.EntityFrameworkCore;

namespace lab5
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base()
        {
            Database.EnsureCreated();
        }

        public DbSet<Book> Books{get; set;}
        public DbSet<Author> Authors { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=YourDatabaseName;Trusted_Connection=True;");
            }
        }

    }
}
