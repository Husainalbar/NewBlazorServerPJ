using Microsoft.EntityFrameworkCore;

namespace NewBlazorServerPJ.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<GameModel> Games { get; set; }
    }
}
