using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proiect_MPD.Data;
using Proiect_MPD.Models;

namespace Proiect_MPD.Pages.Overviews
{
    public class EditModel : PageModel
    {
        private readonly Proiect_MPD.Data.Proiect_MPDContext _context;

        public EditModel(Proiect_MPD.Data.Proiect_MPDContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Overview Overview { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Overview == null)
            {
                return NotFound();
            }

            var overview =  await _context.Overview.FirstOrDefaultAsync(m => m.ID == id);
            if (overview == null)
            {
                return NotFound();
            }
            Overview = overview;
            ViewData["CategorieID"] = new SelectList(_context.Set<Categorie>(), "ID", "CategorieName");
            ViewData["CursaID"] = new SelectList(_context.Set<Cursa>(), "ID", "CursaName");
            ViewData["LocatieID"] = new SelectList(_context.Set<Locatie>(), "ID", "LocatieName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Overview).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OverviewExists(Overview.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool OverviewExists(int id)
        {
          return _context.Overview.Any(e => e.ID == id);
        }
    }
}
