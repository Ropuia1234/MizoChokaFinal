using Microsoft.EntityFrameworkCore;
using MizoChokaFinal.API.Models;

namespace MizoChokaFinal.API.Data
{
    public class DataContext : DbContext
    {
         public DataContext(DbContextOptions<DataContext> options) : base(options){}

         public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
        // public DbSet<Photo> Photos { get; set; }

    }
}