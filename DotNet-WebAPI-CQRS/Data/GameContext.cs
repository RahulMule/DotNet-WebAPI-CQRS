using DotNet_WebAPI_CQRS.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet_WebAPI_CQRS.Data
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options) : base(options)
        {
        }
        public DbSet<Game> games { get; set; }
    }
}
