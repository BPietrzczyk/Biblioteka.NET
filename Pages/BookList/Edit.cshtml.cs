using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projekt_Biblioteka.Data;
using Projekt_Biblioteka.Models;

namespace Projekt_Biblioteka.Pages.BookList
{
    public class EditModel : PageModel
    {
        private ApplicationDbContext _db;

        public string Error = "";

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Book Book { get; set; }
        public List<Book> Books { get; set; }

        public async Task OnGet(int id)
        {
            Book = await _db.Book.FindAsync(id);
            Books = _db.Book.ToList();
        }

        public async Task<IActionResult> OnPost()
        {
            Books = _db.Book.ToList();
            var BookFromDb = await _db.Book.FindAsync(Book.Id);
            if (ModelState.IsValid)
            {
                foreach(Book bookLocal in Books)
                {
                    if (bookLocal.LibraryNumber.Equals(Book.LibraryNumber))
                    {
                        if (!(bookLocal.Id == BookFromDb.Id))
                        {
                            Error = "Podano istniej�cy ju� numer wewn�trzny.";
                            return Page();
                        }
                    }
                }
                BookFromDb.Name = Book.Name;
                BookFromDb.Author = Book.Author;
                BookFromDb.ISBN = Book.ISBN;
                BookFromDb.LibraryNumber = Book.LibraryNumber;

                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}
