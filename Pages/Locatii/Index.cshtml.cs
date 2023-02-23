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
    public class IndexModel : PageModel
    {
        private readonly Proiect_MPD.Data.Proiect_MPDContext _context;

        public IndexModel(Proiect_MPD.Data.Proiect_MPDContext context)
        {
            _context = context;
        }

        public IList<Locatie> Locatie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Locatie != null)
            {
                Locatie = await _context.Locatie.ToListAsync();
            }
        }
    }
}
