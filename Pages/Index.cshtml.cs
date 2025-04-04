using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PAW_LAB_4_5.Models;

namespace PAW_LAB_4_5.Pages
{
    public class IndexModel : PageModel
    {
        private readonly StiriContext _stiriContext;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, StiriContext stiriContext)
        {
            _logger = logger;
            _stiriContext = stiriContext;
        }

        public List<Stire> Stiri { get; set; } = new();

        public void OnGet()
        {
            Stiri = _stiriContext.Stiri.Include(s => s.Categorie).ToList();
        }
    }
}