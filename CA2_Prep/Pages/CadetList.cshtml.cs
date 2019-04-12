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
    public class CadetListModel : PageModel
    {
        private readonly StarfleetContext _db;

        [TempData]
        public string Message { get; set; }

        [TempData]
        public string DelMessage { get; set; }

        public CadetListModel(StarfleetContext db)
        {
            _db = db;
        }

        public IList<Officer> Officers { get; private set; }

        public async Task OnGetAsync()
        {
            Officers = await _db.Officers.AsNoTracking().ToListAsync();
        }
    }
}