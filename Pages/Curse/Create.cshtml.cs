using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect_MPD.Data;
using Proiect_MPD.Models;

namespace Proiect_MPD.Pages.Curse
{
    public class CreateModel : PageModel
    {
        private readonly Proiect_MPD.Data.Proiect_MPDContext _context;

        public CreateModel(Proiect_MPD.Data.Proiect_MPDContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Cursa Cursa { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cursa.Add(Cursa);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
