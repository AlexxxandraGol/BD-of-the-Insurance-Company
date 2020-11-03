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
    public class PayMarkModel : PageModel
    {
        private readonly BD_of_the_Insurance_Company.Data.BD_of_the_Insurance_CompanyContext _context;

        public PayMarkModel(BD_of_the_Insurance_Company.Data.BD_of_the_Insurance_CompanyContext context)
        {
            _context = context;
        }

        public IList<Policies> Policies { get; set; }
        public Policies Policies_ { get; set; }
        public async Task<IActionResult> OnGetAsync(string? Mark)
        {

            if (Mark == null)
            {
                return NotFound();
            }

            Policies_ = await _context.Policies.FirstOrDefaultAsync(m => m.Payment_mark == Mark);

            if (Policies_ == null)
            {
                return NotFound();
            }
            Policies = await _context.Policies.Where(m => m.Payment_mark == Policies_.Payment_mark).ToListAsync();
            return Page();
        }
    }
}
