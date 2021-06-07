using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projekt_Biblioteka.Data;
using Projekt_Biblioteka.Models;

namespace Projekt_Biblioteka.Pages.BookList
{
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public string Error = "";
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<BorrowedList> BorrowedBooks { get; set; }

        public async Task OnGetAsync()
        {

                Books = await _db.Book.ToListAsync();
                BorrowedBooks = await _db.BorrowedLists.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var book = await _db.Book.FindAsync(id);
            Books = await _db.Book.ToListAsync();
            BorrowedBooks = await _db.BorrowedLists.ToListAsync();
            if (book == null)
            {
                return NotFound();
            }
            foreach(BorrowedList borrowed in BorrowedBooks)
            {
                if (borrowed.BookId.Equals(book.Id))
                {
                    Error = "Nie mo¿na usun¹æ wypo¿yczonej ksi¹¿ki!";
                    return Page();
                }
            }
            _db.Book.Remove(book);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }

        public async Task<IActionResult> OnPostEdit(int id)
        {
            var book = await _db.Book.FindAsync(id);
            Books = await _db.Book.ToListAsync();
            BorrowedBooks = await _db.BorrowedLists.ToListAsync();
            if (book == null)
            {
                return NotFound();
            }
            foreach (BorrowedList borrowed in BorrowedBooks)
            {
                if (borrowed.BookId.Equals(book.Id))
                {
                    Error = "Nie mo¿na edytowaæ wypo¿yczonej ksi¹¿ki!";
                    return Page();
                }
            }
            return RedirectToPage("Edit", new { id = id });
        }
    }
}
