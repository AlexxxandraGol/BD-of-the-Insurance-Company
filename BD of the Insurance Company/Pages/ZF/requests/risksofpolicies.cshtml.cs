using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BD_of_the_Insurance_Company.Data;
using BD_of_the_Insurance_Company.Models;

namespace BD_of_the_Insurance_Company.Pages.ZF.requests
{
    public class risksofpoliciesModel : PageModel
    {
        private readonly BD_of_the_Insurance_Company.Data.BD_of_the_Insurance_CompanyContext _context;

        public risksofpoliciesModel(BD_of_the_Insurance_Company.Data.BD_of_the_Insurance_CompanyContext context)
        {
            _context = context;
        }

        public IList<Policy_type> Policy_type { get; set; }
        public IList<Risks> Risks { get; set; }
        public async Task OnGetAsync()
        {
            Policy_type = await _context.Policy_type.ToListAsync();
            Risks = await _context.Risks.ToListAsync();
        }
    }
}
