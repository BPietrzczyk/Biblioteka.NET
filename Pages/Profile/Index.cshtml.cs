using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projekt_Biblioteka.Models;

namespace Projekt_Biblioteka.Pages.Profile
{
    public class IndexModel : PageModel
    {
        private User user;
        private bool isUser;

        public IndexModel()
        {
        }

        public IActionResult OnGet()
        {
            setUp();
            if (!isUser)
                return new RedirectToPageResult("../Login");
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
    }
}
