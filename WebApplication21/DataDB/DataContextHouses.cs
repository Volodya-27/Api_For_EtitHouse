using Microsoft.EntityFrameworkCore;
using WebApplication21.Models;

namespace WebApplication21.DataDB
{
    public class DataContextHouses:DbContext
    {
        public DataContextHouses(DbContextOptions options) : base(options) { }
        public DbSet<House> Houses { get; set; }
    }
}
