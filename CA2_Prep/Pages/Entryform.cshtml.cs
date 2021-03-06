﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CA2_Prep.Model;
using Microsoft.EntityFrameworkCore;

namespace CA2_Prep.Pages
{
    public class EntryformModel : PageModel
    {
        [BindProperty]
        public Officer Officer { get; set; }

        private readonly StarfleetContext _db;


               
        public EntryformModel (StarfleetContext db)
        {
            _db = db;
        }

        [TempData]
        public string Message { get; set; }


        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            //Method to check if the requested confirmation page is valid

            if (ModelState.IsValid)
            {
                _db.Officers.Add(Officer);
                await _db.SaveChangesAsync();
                Message = $"Cadet {Officer.ID} has been added";
                return RedirectToPage("EntryConfirmation", new { id = Officer.ID });

            }
            else
            {
                return Page();
            }
            

          

        }
    }
}