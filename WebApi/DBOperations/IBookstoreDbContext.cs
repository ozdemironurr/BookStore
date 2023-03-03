using Microsoft.EntityFrameworkCore;
using BookStore.Entities;
using WebApi.Entities;

namespace WebApi.DBOperations
{
    public interface IBookStoreDbContext 
    {
        public DbSet<Book> Books {get; set;}
        public DbSet<Genre> Genres {get; set;}
        public DbSet<Author> Authors {get; set;}
        public DbSet<Customer> Customers { get; set; }
        int SaveChanges();
    }
}