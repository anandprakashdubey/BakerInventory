using BakeryCake.Model;
using Microsoft.EntityFrameworkCore;

namespace BakeryCake.Db
{
    public class BakeryCakeDbContext: DbContext
    {
        public BakeryCakeDbContext(DbContextOptions<BakeryCakeDbContext> options) : base(options)
        { }

        public DbSet<CakeModel> Cake { get; set; }
    }
}
