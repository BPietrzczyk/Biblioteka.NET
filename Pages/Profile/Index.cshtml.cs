using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projekt_Biblioteka.Data;
using Projekt_Biblioteka.Models;

namespace Projekt_Biblioteka.Pages.Profile
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public List<Book> borriwedBooks;

        private User user;
        private bool isUser;

        public IndexModel(ApplicationDbContext db)
        {
            this._db = db;
        }

        public IActionResult OnGet()
        {
            setUp();
            if (!isUser)
                return new RedirectToPageResult("../Login");

            borriwedBooks = getUserBorrowedBooks(user.Id);
            return Page();
        }

        public IActionResult OnPost(string profile, string returnBookId)
        {
            if(profile == "Logout")
            {
                HttpContext.Session.Remove("UserId");
                HttpContext.Session.Remove("UserLogin");
                HttpContext.Session.Remove("UserEmail");

                return new RedirectToPageResult("../Login");
            } else if (profile == "Edit")
            {
                return new RedirectToPageResult("./Edit");
            }


            if(returnBookId.Length > 0)
            {
                Book BookFromDb = _db.Book.Find(Int32.Parse(returnBookId));
                BookFromDb.IsBorrowed = "No";

                BorrowedList[] borrowedArray = _db.BorrowedLists.ToArray();
                BorrowedList borrowed = null;
                foreach(BorrowedList b in borrowedArray)
                {
                    if(b.BookId == Int32.Parse(returnBookId))
                    {
                        borrowed = b;
                        break;
                    }
                }

                _db.BorrowedLists.Remove(borrowed);
                _db.SaveChanges();

                var userId = "";
                byte[] valueID;

                HttpContext.Session.TryGetValue("UserId", out valueID);
                try
                {
                    userId = System.Text.Encoding.UTF8.GetString(valueID);
                }
                catch (Exception e) { }

                borriwedBooks = getUserBorrowedBooks(Int32.Parse(userId));
            }

            return Page();
        }


        private void setUp() {
            var userId = "";
            var userLogin = "";
            var userEmail = "";
            byte[] valueID;
            byte[] valueLogin;
            byte[] valueEmail;

            HttpContext.Session.TryGetValue("UserId", out valueID);
            HttpContext.Session.TryGetValue("UserLogin", out valueLogin);
            HttpContext.Session.TryGetValue("UserEmail", out valueEmail);
            try
            {
                userId = System.Text.Encoding.UTF8.GetString(valueID);
                userLogin = System.Text.Encoding.UTF8.GetString(valueLogin);
                userEmail = System.Text.Encoding.UTF8.GetString(valueEmail);
            }
            catch (Exception e) { }

            try
            {
                user = new User();
                user.Id = Int32.Parse(userId);
                user.Login = userLogin;
                user.Email = userEmail;
                isUser = true;
            }
            catch (Exception e)
            {
                isUser = false;
            }
        }

        private List<Book> getUserBorrowedBooks(int userId)
        {
            BorrowedList[] allBorrowed = this._db.BorrowedLists.ToArray();

            List<int> borrowedResult = new List<int>();

            foreach (BorrowedList borrowedBook in allBorrowed) {
                if (userId == borrowedBook.UserId)
                    borrowedResult.Add(borrowedBook.BookId);
            }

            Book[] books = this._db.Book.ToArray();
            return (from Book book in books
                    from int borrowedBook in borrowedResult
                    where borrowedBook == book.Id
                    select book).ToList();
        }
    }
}
