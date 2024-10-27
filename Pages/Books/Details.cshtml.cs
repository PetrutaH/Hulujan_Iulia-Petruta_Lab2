using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hulujan_Iulia_Petruta_Lab2.Data;
using Hulujan_Iulia_Petruta_Lab2.Models;
using System.Net;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Hulujan_Iulia_Petruta_Lab2.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Hulujan_Iulia_Petruta_Lab2.Data.Hulujan_Iulia_Petruta_Lab2Context _context;

        public DetailsModel(Hulujan_Iulia_Petruta_Lab2.Data.Hulujan_Iulia_Petruta_Lab2Context context)
        {
            _context = context;
        }

        public Book Book { get; set; } = default!;

        [Display(Name = "Author")]
        public string AuthorFullName { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book
               .Include(b => b.Publisher)
                .Include(b => b.Author)
                .Include(b => b.BookCategories)
                .ThenInclude(b => b.Category)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);


            if (Book == null)
            {
                return NotFound();
            }
            
            var authorFullName = Book.Author.FirstName + " " + Book.Author.LastName;

            this.AuthorFullName = authorFullName;

            //Book.Categories = _context.Category.Select(x +> s.Category).Where(BookID = id);

            //var bookCategories 

            //this.Book.

            //BookD.Books = Book;

            //if (id != null)
            //{
            //    BookID = id.Vale;
            //    Book book = BookD.Books
            //        .Where(i => i.ID == id.Value).Single();
            //    BookD.Categories = book.BookCategories.Select(s => s.Category);
            //}


            return Page();
        }
    }
}
