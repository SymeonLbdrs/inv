using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using inv.Models;

namespace inv.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly inv.Models.invContext _context;

        public CreateModel(inv.Models.invContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public product product { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.product.Add(product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
