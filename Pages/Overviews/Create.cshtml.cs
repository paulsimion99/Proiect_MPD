using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect_MPD.Data;
using Proiect_MPD.Models;

namespace Proiect_MPD.Pages.Overviews
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
            ViewData["CategorieID"] = new SelectList(_context.Set<Categorie>(), "ID","CategorieName");
            ViewData["CursaID"] = new SelectList(_context.Set<Cursa>(), "ID", "CursaName");
            ViewData["LocatieID"] = new SelectList(_context.Set<Locatie>(), "ID", "LocatieName");
            return Page();
        }

        [BindProperty]
        public Overview Overview { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Overview.Add(Overview);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
