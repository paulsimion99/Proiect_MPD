﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_MPD.Data;
using Proiect_MPD.Models;

namespace Proiect_MPD.Pages.Curse
{
    public class DetailsModel : PageModel
    {
        private readonly Proiect_MPD.Data.Proiect_MPDContext _context;

        public DetailsModel(Proiect_MPD.Data.Proiect_MPDContext context)
        {
            _context = context;
        }

      public Cursa Cursa { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Cursa == null)
            {
                return NotFound();
            }

            var cursa = await _context.Cursa.FirstOrDefaultAsync(m => m.ID == id);
            if (cursa == null)
            {
                return NotFound();
            }
            else 
            {
                Cursa = cursa;
            }
            return Page();
        }
    }
}
