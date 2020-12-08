using CommandAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandAPI.Models
{
    public class CommandDbContext : DbContext
    {
        public CommandDbContext(DbContextOptions<CommandDbContext> options) : base(options)
        {

        }

        public DbSet<CommandItem> CommandItems { get; set; }
    }
}