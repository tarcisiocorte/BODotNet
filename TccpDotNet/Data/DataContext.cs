using TccpDotNet.Models;
using Microsoft.EntityFrameworkCore;

namespace TccpDotNet.Data
{
    public class DataContext : Microsoft.EntityFrameworkCore.DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
