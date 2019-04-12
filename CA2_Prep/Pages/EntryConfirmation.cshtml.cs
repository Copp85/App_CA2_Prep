using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CA2_Prep.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CA2_Prep.Pages
{
    public class EntryConfirmationModel : PageModel
    {
        private readonly StarfleetContext _db;

        //For Tempdata message
        [TempData]
        public string Message { get; set; }


        public EntryConfirmationModel (StarfleetContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Officer Officer { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            Officer = await _db.Officers.FindAsync(id);




            if (Officer == null)
            {
                return NotFound();
            }
            return Page();



        }
    }
}