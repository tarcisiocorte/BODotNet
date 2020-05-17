using BODotNet.Models;
using Microsoft.EntityFrameworkCore;

namespace BODotNet.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
