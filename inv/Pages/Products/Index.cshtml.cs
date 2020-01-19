using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using inv.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace inv.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly inv.Models.invContext _context;

        public IndexModel(inv.Models.invContext context)
        {
            _context = context;
        }

        public IList<product> product { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        

        public async Task OnGetAsync()
        {
            var name = from m in _context.product
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                name= name.Where(s => s.Name.Contains(SearchString));
            }
            product = await name.ToListAsync();
        }
    }
}
