using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projekt_Biblioteka.Data;
using Projekt_Biblioteka.Models;

namespace Projekt_Biblioteka.Pages.Profile
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public List<Book> borriwedBooks;

        public String errorMessage = "";

        private User user;
        private bool isUser;

        public EditModel(ApplicationDbContext db)
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

        public IActionResult OnPost(string profile, string editLogin, string editEmail, string editPassword)
        {
            setUp();
            if (profile == "Logout")
            {
                HttpContext.Session.Remove("UserId");
                HttpContext.Session.Remove("UserLogin");
                HttpContext.Session.Remove("UserEmail");

                return new RedirectToPageResult("../Login");
            }
            else if (profile == "Delete")
            {
                borriwedBooks = getUserBorrowedBooks(user.Id);
                if (borriwedBooks.Count > 0)
                {
                    errorMessage = "Masz wypo¿yczone ksi¹¿ki, trzeba je oddaæ zanim usuniesz konto.";
                    return Page();
                }

                _db.User.Remove(user);
                _db.SaveChanges();

                HttpContext.Session.Remove("UserId");
                HttpContext.Session.Remove("UserLogin");
                HttpContext.Session.Remove("UserEmail");

                return new RedirectToPageResult("../Login");
            }




            // edit Profile
            if (editEmail != null && editLogin != null && editPassword != null)
            {
                List<User> users = _db.User.ToList();
                bool changeLogin = true;
                bool changeEmail = true;

                foreach (User u in users)
                {
                    if (u.Login == editLogin && u.Id != user.Id)
                    {
                        changeLogin = false;
                        break;
                    }
                    if (u.Email == editEmail && u.Id != user.Id)
                    {
                        changeEmail = false;
                        break;
                    }
                }

                if (changeEmail && changeLogin)
                {
                    user.Login = editLogin;
                    user.Email = editEmail;
                    user.Password = editPassword;
                    //_db.SaveChanges();
                    //_db.User.Find(user.Id);

                    var result = _db.User.SingleOrDefault(b => b.Id == user.Id);
                    if (result != null)
                    {
                        result.Login = editLogin;
                        result.Email = editEmail;
                        result.Password = editPassword;
                        _db.SaveChanges();

                        HttpContext.Session.Set("UserLogin", Encoding.UTF8.GetBytes(editLogin));
                        HttpContext.Session.Set("UserEmail", Encoding.UTF8.GetBytes(editEmail));
                        errorMessage = "Zmieniono dane";
                    }
                    else
                        errorMessage = "Nie zmieniono danych";
                    //_db.User.Update(user);
                    //_db.SaveChanges();


                    return Page();
                }
            }
            else if (editEmail != null && editLogin != null)
            {
                List<User> users = _db.User.ToList();
                bool changeLogin = true;
                bool changeEmail = true;

                foreach (User u in users)
                {
                    if (u.Login == editLogin && u.Id != user.Id)
                    {
                        changeLogin = false;
                        break;
                    }
                    if (u.Email == editEmail && u.Id != user.Id)
                    {
                        changeEmail = false;
                        break;
                    }
                }

                if (changeEmail && changeLogin)
                {
                    user.Login = editLogin;
                    user.Email = editEmail;
                    //_db.SaveChanges();
                    //_db.User.Find(user.Id);

                    var result = _db.User.SingleOrDefault(b => b.Id == user.Id);
                    if (result != null)
                    {
                        result.Login = editLogin;
                        result.Email = editEmail;
                        _db.SaveChanges();

                        HttpContext.Session.Set("UserLogin", Encoding.UTF8.GetBytes(editLogin));
                        HttpContext.Session.Set("UserEmail", Encoding.UTF8.GetBytes(editEmail));
                        errorMessage = "Zmieniono login i email";
                    }
                    else
                        errorMessage = "Nie zmieniono danych";
                    //_db.User.Update(user);
                    //_db.SaveChanges();


                    return Page();
                }
            }
            else if (editEmail != null)
            {
                List<User> users = _db.User.ToList();
                bool changeEmail = true;

                foreach (User u in users)
                {
                    if (u.Email == editEmail && u.Id != user.Id)
                    {
                        changeEmail = false;
                        break;
                    }
                }

                if (changeEmail)
                {
                    user.Email = editEmail;

                    var result = _db.User.SingleOrDefault(b => b.Id == user.Id);
                    if (result != null)
                    {
                        result.Email = editEmail;
                        _db.SaveChanges();

                        HttpContext.Session.Set("UserEmail", Encoding.UTF8.GetBytes(editEmail));
                        errorMessage = "Zmieniono email";
                    }
                    else
                        errorMessage = "Nie zmieniono danych";
                    //_db.User.Update(user);
                    //_db.SaveChanges();


                    return Page();
                }
            }
            else if (editLogin != null)
            {
                List<User> users = _db.User.ToList();
                bool changeLogin = true;

                foreach (User u in users)
                {
                    if (u.Login.Equals(editLogin) && u.Id != user.Id)
                    {
                        changeLogin = false;
                        break;
                    }
                }

                if (changeLogin)
                {
                    user.Login = editLogin;

                    var result = _db.User.SingleOrDefault(b => b.Id == user.Id);
                    if (result != null)
                    {
                        result.Login = editLogin;
                        _db.SaveChanges();

                        HttpContext.Session.Set("UserLogin", Encoding.UTF8.GetBytes(editLogin));
                        errorMessage = "Zmieniono Login";
                    }
                    else
                        errorMessage = "Nie zmieniono danych.";
                    //_db.User.Update(user);
                    //_db.SaveChanges();


                    return Page();
                } else
                    errorMessage = "Ju¿ istnieje u¿ytkownik z takim Loginem.";
            }
            else if (editPassword != null)
            {
                List<User> users = _db.User.ToList();

                if (editPassword.Length < 8)
                {
                    user.Password = editPassword;

                    var result = _db.User.SingleOrDefault(b => b.Id == user.Id);
                    if (result != null)
                    {
                        result.Password = editPassword;
                        _db.SaveChanges();

                        errorMessage = "Zmieniono has³o.";
                    }
                    else
                        errorMessage = "Nie zmieniono danych";
                    //_db.User.Update(user);
                    //_db.SaveChanges();


                    return Page();
                }
                else
                {
                    errorMessage = "has³o jest za krótkie.";
                    return Page();
                }
            }

            return Page();
        }


        private void setUp()
        {
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

            foreach (BorrowedList borrowedBook in allBorrowed)
            {
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
