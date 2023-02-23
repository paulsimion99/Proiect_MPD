using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_MPD.Data;
using Proiect_MPD.Models;
using Proiect_MPD.Models.ViewModels;

namespace Proiect_MPD.Pages.Categorii
{
    public class IndexModel : PageModel
    {
        private readonly Proiect_MPD.Data.Proiect_MPDContext _context;

        public IndexModel(Proiect_MPD.Data.Proiect_MPDContext context)
        {
            _context = context;
        }

        public IList<Categorie> Categorie { get;set; } = default!;
        public CategorieIndexData CategorieData { get; set; }
        public int CategorieID { get; set; }
        public int OverviewID { get; set; }
        public async Task OnGetAsync(int? id, int? overviewID)
        {
            CategorieData = new CategorieIndexData();
            CategorieData.Categorii = await _context.Categorie
            .Include(i => i.Overviews)
            .ThenInclude(c => c.Cursa)
            .OrderBy(i => i.CategorieName)
            .ToListAsync();
            if (id != null)
            {
                CategorieID = id.Value;
                Categorie categorie = CategorieData.Categorii
                .Where(i => i.ID == id.Value).Single();
                CategorieData.Overviews = categorie.Overviews;
            }
        }

        public async Task OnGetAsync()
        {
            if (_context.Categorie != null)
            {
                Categorie = await _context.Categorie.ToListAsync();
            }
        }
    }
}
