using Microsoft.EntityFrameworkCore;
using SafaricomRestAPI.Models;

namespace SafaricomRestAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Client>  Clients { get; set; }
    }
}
