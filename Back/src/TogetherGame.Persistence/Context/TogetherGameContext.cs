using Microsoft.EntityFrameworkCore;
using TogetherGame.Domain.Entities;

namespace TogetherGame.Persistence
{
    public class TogetherGameContext : DbContext
    {
        public TogetherGameContext(DbContextOptions<TogetherGameContext> Options) : base(Options)
        { }
        public DbSet<Game> Games { get; set; }

    }
}