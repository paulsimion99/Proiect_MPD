using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_MPD.Data;
using Proiect_MPD.Models;

namespace Proiect_MPD.Pages.Locatii
{
    public class DeleteModel : PageModel
    {
        private readonly Proiect_MPD.Data.Proiect_MPDContext _context;

        public DeleteModel(Proiect_MPD.Data.Proiect_MPDContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Locatie Locatie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Locatie == null)
            {
                return NotFound();
            }

            var locatie = await _context.Locatie.FirstOrDefaultAsync(m => m.ID == id);

            if (locatie == null)
            {
                return NotFound();
            }
            else 
            {
                Locatie = locatie;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Locatie == null)
            {
                return NotFound();
            }
            var locatie = await _context.Locatie.FindAsync(id);

            if (locatie != null)
            {
                Locatie = locatie;
                _context.Locatie.Remove(Locatie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
