using Microsoft.EntityFrameworkCore;
using WalkingSkeleton.API.Models;

namespace WalkingSkeleton.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        public DbSet<Value> Values { get; set; }
    }
}