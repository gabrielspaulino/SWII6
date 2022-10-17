using Microsoft.EntityFrameworkCore;
using TP02.Models;

namespace TP02.Repository
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        { }

        public DbSet<BL> BL { get; set; }
        public DbSet<Container> Container { get; set; }
    }
}
