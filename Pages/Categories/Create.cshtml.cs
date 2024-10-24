using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Hulujan_Iulia_Petruta_Lab2.Data;
using Hulujan_Iulia_Petruta_Lab2.Models;

namespace Hulujan_Iulia_Petruta_Lab2.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Hulujan_Iulia_Petruta_Lab2.Data.Hulujan_Iulia_Petruta_Lab2Context _context;

        public CreateModel(Hulujan_Iulia_Petruta_Lab2.Data.Hulujan_Iulia_Petruta_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
