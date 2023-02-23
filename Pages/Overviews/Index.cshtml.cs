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
    public class IndexModel : PageModel
    {
        private readonly Proiect_MPD.Data.Proiect_MPDContext _context;

        public IndexModel(Proiect_MPD.Data.Proiect_MPDContext context)
        {
            _context = context;
        }

        public IList<Overview> Overview { get;set; } = default!;


        public async Task OnGetAsync()
        {
            if (_context.Overview != null)
            {
                Overview = await _context.Overview
                    .Include(b=>b.Categorie)
                    .Include(b => b.Cursa)
                    .Include(b => b.Locatie)
                    .ToListAsync();
            }
        }
    }
}
