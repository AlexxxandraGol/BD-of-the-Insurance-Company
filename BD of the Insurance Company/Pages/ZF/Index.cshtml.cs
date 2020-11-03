using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BD_of_the_Insurance_Company.ZF
{
    public class IndexModel : PageModel
    {
        private readonly BD_of_the_Insurance_Company.Data.BD_of_the_Insurance_CompanyContext _context;

        public IndexModel(BD_of_the_Insurance_Company.Data.BD_of_the_Insurance_CompanyContext context)
        {
            _context = context;
        }
        public List<SelectListItem> SelPosition { get; set; }
        public List<SelectListItem> Client { get; set; }
        public List<SelectListItem> Type { get; set; }
        public List<SelectListItem> Mark { get; set; }
        public List<SelectListItem> Data { get; set; }

        public IActionResult OnGet()
        {
            SelPosition = _context.Position.Select(p =>
                new SelectListItem
                {
                    Value = p.ID.ToString(),
                    Text = p.Position_name
                }).ToList();

            Client = _context.Groups.Select(p =>
               new SelectListItem
               {
                   Value = p.ID.ToString(),
                   Text = p.Groups_name
               }).ToList();

            Type = _context.Policy_type.Select(p =>
               new SelectListItem
               {
                   Value = p.ID.ToString(),
                   Text = p.Policy_type_name
               }).ToList();

            Mark = _context.Policies.Select(p =>
               new SelectListItem
               {
                   Value = p.Payment_mark.ToString(),
                   Text = p.Payment_mark
               }).ToList();

            Data = _context.Policies.Select(p =>
              new SelectListItem
              {
                  Value = p.End_mark.ToString(),
                  Text = p.End_mark
              }).ToList();

            return Page();
        }
        
    }
}

