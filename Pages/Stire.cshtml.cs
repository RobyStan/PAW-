using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PAW_LAB_4_5.Models;

namespace PAW_LAB_4_5.Pages
{
    public class StireModel : PageModel
    {
        private readonly StiriContext _stiriContext;

        public StireModel(StiriContext stiriContext)
        {
            _stiriContext = stiriContext;
        }

        public Stire Stire { get; set; }

        public IActionResult OnGet(int stireId)
        {
            Stire = _stiriContext.Stiri
                .Include(s => s.Categorie)
                .FirstOrDefault(s => s.Id == stireId);

            if (Stire == null)
            {
                return RedirectToPage("/Error"); 
            }

            return Page();
        }
    }
}
