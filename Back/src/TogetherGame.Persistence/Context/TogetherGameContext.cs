using Microsoft.EntityFrameworkCore;

namespace TogetherGame.Persistence
{
    public class TogetherGameContext : DbContext
    {
        public TogetherGameContext(DbContextOptions<TogetherGameContext> options) : base(options)
        { }
    }
}