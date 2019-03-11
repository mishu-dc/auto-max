using AutoMax.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoMax.Persistence
{
    public class AutoMaxDbContext:DbContext
    {
        public AutoMaxDbContext(DbContextOptions<AutoMaxDbContext> options)
            :base(options)
        {
            
        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }
    }
}