using Microsoft.EntityFrameworkCore;
using CourseApi.Models;

namespace CourseApi.Data{
    public class DataContext : DbContext {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<Customer> Customers {get; set;}
        public DbSet<Account> Accounts {get; set;}
    }
}