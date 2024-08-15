using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic;
using PokemonLibrary;

namespace repeatRazorPages.Pages;

public class PokemonsPageModel : PageModel
{
    public void OnGet()
    {
        ViewData["Title"] = "Pokedex";
    }
    [BindProperty]
    public Pokemon? myPokemon { get; set; }

    public IActionResult OnPost()
    {
        if (myPokemon is not null && ModelState.IsValid)
        {
            PokemonStorege.Pokemons.Add(myPokemon);       
			return RedirectToPage("/PokemonsPage");
		}
        return Page();
    }
    //public IActionResult OnPost()
    //{
    //    if (myPokemon is not null && ModelState.IsValid) 
    //    { 
    //        PokemonStorege.Pokemons.Add(myPokemon);
    //        return RedirectToPage("/PokemonsPage");
    //    }
    //    return Page();
    //}
}
