using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projekt_Biblioteka.Models;

namespace Projekt_Biblioteka.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public User user { get; set; }

        [BindProperty(SupportsGet = true, Name = "ai_user")]
        public String userString { get; set; }

        public void OnGet()
        {

            //HttpContext.Session.Set("User", Encoding.UTF8.GetBytes(user.ToString()));
            //this.SignIn();
        }

     
    }
}
