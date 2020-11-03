using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BD_of_the_Insurance_Company.Data;
using BD_of_the_Insurance_Company.Models;

namespace BD_of_the_Insurance_Company.Pages.ZF.filters
{
    public class PoliciesDataModel : PageModel
    {
        private readonly BD_of_the_Insurance_Company.Data.BD_of_the_Insurance_CompanyContext _context;

        public PoliciesDataModel(BD_of_the_Insurance_Company.Data.BD_of_the_Insurance_CompanyContext context)
        {
            _context = context;
        }

        public IList<Policies> Policies { get; set; }
        public Policies Policies_ { get; set; }
        public async Task<IActionResult> OnGetAsync(string? End)
        {

            if (End == null)
            {
                return NotFound();
            }

            Policies_ = await _context.Policies.FirstOrDefaultAsync(m => m.End_mark == End);

            if (Policies_ == null)
            {
                return NotFound();
            }
            Policies = await _context.Policies.Where(m => m.End_mark == Policies_.End_mark).ToListAsync();
            return Page();
        }
    }
}
