using Microsoft.EntityFrameworkCore;

namespace DarpinosPizzaria.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }

    }
}