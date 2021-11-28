using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VoevodPalada_MariusPetre_lab8.Data;
using VoevodPalada_MariusPetre_lab8.Models;

namespace VoevodPalada_MariusPetre_lab8.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly VoevodPalada_MariusPetre_lab8.Data.VoevodPalada_MariusPetre_lab8Context _context;

        public IndexModel(VoevodPalada_MariusPetre_lab8.Data.VoevodPalada_MariusPetre_lab8Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .ToListAsync()
                .Include(b => b.Publisher);

        }
    }
}
