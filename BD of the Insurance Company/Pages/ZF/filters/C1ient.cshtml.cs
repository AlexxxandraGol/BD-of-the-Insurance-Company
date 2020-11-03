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
    public class C1ientModel : PageModel
    {
        private readonly BD_of_the_Insurance_Company.Data.BD_of_the_Insurance_CompanyContext _context;

        public C1ientModel(BD_of_the_Insurance_Company.Data.BD_of_the_Insurance_CompanyContext context)
        {
            _context = context;
        }

        public IList<Client> Client { get; set; }
        public Groups Groups { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Groups = await _context.Groups.FirstOrDefaultAsync(m => m.ID == id);

            if (Groups == null)
            {
                return NotFound();
            }
            Client = await _context.Client.Where(m => m.GroupsID == Groups.ID).ToListAsync();
            return Page();
        }
    }
}
