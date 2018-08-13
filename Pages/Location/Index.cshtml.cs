using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorTute.Models;

namespace RazorTute.Pages.Location
{
    public class IndexModel : PageModel
    {
        private readonly RazorTute.Models.TuteContext _context;

        public IndexModel(RazorTute.Models.TuteContext context)
        {
            _context = context;
        }

        public IList<RazorTute.Models.Location> Location { get;set; }

        public async Task OnGetAsync()
        {
            Location = await _context.Location.ToListAsync();
        }
    }
}
