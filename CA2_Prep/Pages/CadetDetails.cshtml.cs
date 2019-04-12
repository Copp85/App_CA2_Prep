using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CA2_Prep.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CA2_Prep.Pages
{
    public class CadetDetailsModel : PageModel
    {
        private readonly StarfleetContext _db;

        [TempData]
        public string DelMessage { get; set; }

        public CadetDetailsModel(StarfleetContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Officer Officer { get; set; }

        public async Task<IActionResult> OnGetAsync (string id)
        {
            Officer = await _db.Officers.FindAsync(id);
            if (Officer == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var cadet = await _db.Officers.FindAsync(Officer.ID);
            if (cadet != null)
            {
                _db.Officers.Remove(cadet);
                await _db.SaveChangesAsync();
                DelMessage = $"Cadet {Officer.ID}has been deleted";
            }
            
            return RedirectToPage("CadetList");

        }

        
    }
}