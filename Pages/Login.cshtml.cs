using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projekt_Biblioteka.Data;
using Projekt_Biblioteka.Models;

namespace Projekt_Biblioteka.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public User user { get; set; }
        public IEnumerable<User> users { get; set; }

        [BindProperty]
        public String password { get; set; }
        [BindProperty]
        public String login { get; set; }

        private bool isUser;

        private readonly ApplicationDbContext _db;
        public LoginModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult OnGet()
        {
            setUp();
            if (isUser)
                return new RedirectToPageResult("Profile/Index");
            return Page();
        }


        public async Task<IActionResult> OnPost(string login, string password)
        {
            users = await _db.User.ToListAsync();

            foreach (User u in users)
            {
                if(u.Login == login)
                    if(u.Password == password)
                    {
                        user = u;
                        HttpContext.Session.Set("UserId", Encoding.UTF8.GetBytes(user.Id.ToString()));
                        HttpContext.Session.Set("UserLogin", Encoding.UTF8.GetBytes(user.Login));
                        HttpContext.Session.Set("UserEmail", Encoding.UTF8.GetBytes(user.Email));
                        return new RedirectToPageResult("Profile/Index");
                    }
            }

            Console.WriteLine("test");


            return new RedirectToPageResult("Login");
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

    }
}
