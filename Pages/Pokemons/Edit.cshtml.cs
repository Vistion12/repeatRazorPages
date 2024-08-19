using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using repeatRazorPages.Data;
using repeatRazorPages.Model;

namespace repeatRazorPages.Pages.Pokemons;

public class EditModel (PokemonContext pokemonContext) : PageModel
{
	[BindProperty]
	public Pokemon? Pokemon { get; set; }
	public async Task OnGetAsync(int id)
    {
		Pokemon = await pokemonContext.Pokemons.FirstAsync(pokemon => pokemon.Id == id);
	}

	public async Task<IActionResult> OnPostUpdateAsync(int id)
	{
		if (!ModelState.IsValid)
		{
			return Page();
		}

        var updatedPokemon = await pokemonContext.Pokemons.FirstAsync(pokemon => pokemon.Id == id);

		updatedPokemon.Name = Pokemon.Name;
		updatedPokemon.URL = Pokemon.URL;
		updatedPokemon.Description = Pokemon.Description;
		updatedPokemon.Level = Pokemon.Level;
		await pokemonContext.SaveChangesAsync();

        return RedirectToPage("./Index");
	}
}
