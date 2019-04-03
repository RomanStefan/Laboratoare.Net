using Microsoft.EntityFrameworkCore;

namespace lab4
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base()
        {
            Database.EnsureCreated();
        }

        //DbSet's here
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Empoloyees { get; set; }

        // Specify DbSet properties etc
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(customer => customer.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Customer>()
                .Property(customer => customer.Address)
                .IsRequired()
                .HasMaxLength(300);

            modelBuilder.Entity<Customer>()
                .Property(customer => customer.PhoneNumber)
                .IsRequired();

            modelBuilder.Entity<Customer>()
                .Property(customer => customer.Email)
                .IsRequired();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=(localdb)\mssqllocaldb;Database=Yo urDatabaseName;Trusted_Connection=True;");
            }

        }
    }
}
