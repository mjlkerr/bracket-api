using System;
using Microsoft.EntityFrameworkCore;
namespace bracket_api.Models
{
    public class BracketContext : DbContext
    {
        public BracketContext(DbContextOptions<BracketContext> options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
    }
}
