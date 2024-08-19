using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using repeatRazorPages.Data;
using repeatRazorPages.Model;

namespace repeatRazorPages.Pages.Pokemons;

public class AddModel(PokemonContext pokemonContext) : PageModel
{
    
    public void OnGet()
    {
        ViewData["Title"] = "Добавление покемона в базу";
    }
    [BindProperty]
    public Pokemon? Pokemon { get; set; }
    public async Task <IActionResult> OnPostAsync()
    {       
        if (Pokemon is null || !ModelState.IsValid)
        {
            return Page();
        }

        await pokemonContext.Pokemons.AddAsync(Pokemon);
        await pokemonContext.SaveChangesAsync();

        return RedirectToPage("./Index");

    }
}
