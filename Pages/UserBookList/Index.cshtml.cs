using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projekt_Biblioteka.Data;
using Projekt_Biblioteka.Models;

namespace Projekt_Biblioteka.Pages.UserBookList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Book> Books { get; set; }
        public List<Book> BooksNotBorrowed = new List<Book>();

        public async Task OnGetAsync()
        {

            Books = await _db.Book.ToListAsync();
            foreach (Book book in Books)
            {
                if(book.IsBorrowed.Equals("No")){
                    BooksNotBorrowed.Add(book);
                }
            }
        }

        public async Task<IActionResult> OnPostBorrow(int id)
        {
            var book = await _db.Book.FindAsync(id);
            var borrowed = new BorrowedList();
            byte[] userId;
            HttpContext.Session.TryGetValue("UserId", out userId);
            borrowed.UserId = Int32.Parse(System.Text.Encoding.UTF8.GetString(userId));
            borrowed.BookId = id;
            if (book == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                var BookFromDb = await _db.Book.FindAsync(id);
                BookFromDb.IsBorrowed = "Yes";
                await _db.BorrowedLists.AddAsync(borrowed);

                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }

            return RedirectToPage("Index");
        }
    }
}
