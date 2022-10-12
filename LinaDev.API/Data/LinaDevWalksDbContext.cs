using LinaDev.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace LinaDev.API.Data
{
    public class LinaDevWalksDbContext : DbContext
    {

        public LinaDevWalksDbContext(DbContextOptions<LinaDevWalksDbContext> options)
            : base(options)
        {

        }


        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
