using Microsoft.EntityFrameworkCore;
using repeatRazorPages.Model;

namespace repeatRazorPages.Data
{
    public class PokemonContext (DbContextOptions<PokemonContext> options) : DbContext(options)
    {
        public DbSet<Pokemon> Pokemons { get; set; }
    }
}
