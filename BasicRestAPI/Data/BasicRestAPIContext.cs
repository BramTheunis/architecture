using BasicRestAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicRestAPI.Data
{
    public class BasicRestAPIContext : DbContext
    {
        public BasicRestAPIContext(DbContextOptions<BasicRestAPIContext> opt) : base(opt)
        {
            
        }

        public DbSet<Bouquet> Bouquets { get; set; }
        public DbSet<Store> Stores { get; set; }
    }
}