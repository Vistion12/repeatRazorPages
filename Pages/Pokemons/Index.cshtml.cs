using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using repeatRazorPages.Data;
using repeatRazorPages.Model;

namespace repeatRazorPages.Pages.Pokemons
{
    public class IndexModel(PokemonContext pokemonContext) : PageModel        
    {
        public IEnumerable <Pokemon> Pokemons { get; set; } = pokemonContext.Pokemons;
       


        public void OnGet()
        {
            ViewData["Title"] = "pokemons";
        }
        [BindProperty]
        public string? SearchNamePokemon {  get; set; }

        public async Task  OnPostAsync() 
        {
            if (SearchNamePokemon is null)
            {
                return;
            }
            Pokemons=await pokemonContext.Pokemons.Where(pokemon=>pokemon.Name.Contains(SearchNamePokemon)).ToListAsync();
        }
        
    }
}
