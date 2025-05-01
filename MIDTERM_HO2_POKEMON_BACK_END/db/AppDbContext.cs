using Microsoft.EntityFrameworkCore;
using MIDTERM_HO2_POKEMON_BACK_END.models;

namespace MIDTERM_HO2_POKEMON_BACK_END.db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Pokemon> Pokemon { get; set; }
    }
}
