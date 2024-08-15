using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace repeatRazorPages.Pages
{
    public class IndexModel : PageModel
    {
		
		public void OnGet()
		{
			ViewData["Title"] = "Главная страница";
			
		}
	}
}
