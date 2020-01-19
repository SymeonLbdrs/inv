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
    public class DeleteModel : PageModel
    {
        private readonly inv.Models.invContext _context;

        public DeleteModel(inv.Models.invContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            product = await _context.product.FindAsync(id);

            if (product != null)
            {
                _context.product.Remove(product);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
