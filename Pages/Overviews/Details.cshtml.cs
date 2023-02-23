using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_MPD.Data;
using Proiect_MPD.Models;

namespace Proiect_MPD.Pages.Overviews
{
    public class DetailsModel : PageModel
    {
        private readonly Proiect_MPD.Data.Proiect_MPDContext _context;

        public DetailsModel(Proiect_MPD.Data.Proiect_MPDContext context)
        {
            _context = context;
        }

      public Overview Overview { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Overview == null)
            {
                return NotFound();
            }

            var overview = await _context.Overview.FirstOrDefaultAsync(m => m.ID == id);
            if (overview == null)
            {
                return NotFound();
            }
            else 
            {
                Overview = overview;
            }
            return Page();
        }
    }
}
