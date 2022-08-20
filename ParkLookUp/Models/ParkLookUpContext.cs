using Microsoft.EntityFrameworkCore;

namespace ParkLookUp.Models
{
    public class ParkLookUpContext : DbContext
    {
        public ParkLookUpContext(DbContextOptions<ParkLookUpContext> options)
            : base(options)
        {
        }

        public DbSet<Park> Parks { get; set; }
    }
}