using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using repeatRazorPages.Data;
using repeatRazorPages.Model;

namespace repeatRazorPages.Pages.Pokemons;

public class DeleteModel(PokemonContext pokemonContext) : PageModel
{
    public Pokemon? Pokemon { get; set; }
    public async Task OnGetAsync(int id)
    {
        Pokemon =await pokemonContext.Pokemons.FirstAsync(pokemon => pokemon.Id == id);
        
    }

    public async Task <IActionResult> OnPostDeleteAsync(int id)
    {
        var pokemon = await pokemonContext.Pokemons.FirstAsync(pokemon => pokemon.Id == id);
        pokemonContext.Pokemons.Remove(pokemon);

        await pokemonContext.SaveChangesAsync();
        return RedirectToPage("./Index");
	}
}
