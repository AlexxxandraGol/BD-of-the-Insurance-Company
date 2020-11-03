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
    public class PoliciesTypeModel : PageModel
    {
        private readonly BD_of_the_Insurance_Company.Data.BD_of_the_Insurance_CompanyContext _context;

        public PoliciesTypeModel(BD_of_the_Insurance_Company.Data.BD_of_the_Insurance_CompanyContext context)
        {
            _context = context;
        }

        public IList<Policies> Policies { get; set; }
        public Policy_type Policy { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            Policy = await _context.Policy_type.FirstOrDefaultAsync(m => m.ID == id);

            if (Policy == null)
            {
                return NotFound();
            }
            Policies = await _context.Policies.Where(m => m.Policy_typeID == Policy.ID).ToListAsync();
            return Page();
        }
    }
}
