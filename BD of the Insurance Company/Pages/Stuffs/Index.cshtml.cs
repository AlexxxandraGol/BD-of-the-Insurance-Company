using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BD_of_the_Insurance_Company.Data;
using BD_of_the_Insurance_Company.Models;

namespace BD_of_the_Insurance_Company.Pages.Stuffs
{
    public class IndexModel : PageModel
    {
        private readonly BD_of_the_Insurance_Company.Data.BD_of_the_Insurance_CompanyContext _context;

        public IndexModel(BD_of_the_Insurance_Company.Data.BD_of_the_Insurance_CompanyContext context)
        {
            _context = context;
        }

        public IList<Staff> Staff { get;set; }
        public IList<Position> Position { get; set; }
        public async Task OnGetAsync()
        {
            Staff = await _context.Staff.ToListAsync();
            Position = await _context.Position.ToListAsync();
        }
    }
}
