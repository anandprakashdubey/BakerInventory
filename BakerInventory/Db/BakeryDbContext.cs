using BakerInventory.Model;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BakerInventory.Db
{
    public class BakeryDbContext: DbContext
    {
        public BakeryDbContext(DbContextOptions<BakeryDbContext> options) : base(options)
        { }

        public DbSet<BakeryModel> Bakery { get; set; }
    }
}
