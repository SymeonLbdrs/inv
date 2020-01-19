using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using inv.Models;

namespace inv.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly inv.Models.invContext _context;

        public DetailsModel(inv.Models.invContext context)
        {
            _context = context;
        }

        public product product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            product = await _context.product.FirstOrDefaultAsync(m => m.ID == id);

            if (product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
