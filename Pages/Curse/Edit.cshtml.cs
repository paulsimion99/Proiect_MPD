﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proiect_MPD.Data;
using Proiect_MPD.Models;

namespace Proiect_MPD.Pages.Curse
{
    public class EditModel : PageModel
    {
        private readonly Proiect_MPD.Data.Proiect_MPDContext _context;

        public EditModel(Proiect_MPD.Data.Proiect_MPDContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cursa Cursa { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Cursa == null)
            {
                return NotFound();
            }

            var cursa =  await _context.Cursa.FirstOrDefaultAsync(m => m.ID == id);
            if (cursa == null)
            {
                return NotFound();
            }
            Cursa = cursa;
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

            _context.Attach(Cursa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CursaExists(Cursa.ID))
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

        private bool CursaExists(int id)
        {
          return _context.Cursa.Any(e => e.ID == id);
        }
    }
}
