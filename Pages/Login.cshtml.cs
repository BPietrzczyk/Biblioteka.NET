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
<<<<<<< HEAD

        private readonly Data.ApplicationDbContext _db;

        public LoginModel(Data.ApplicationDbContext db)
        {
            _db = db;
        }

        public User user { get; set; }

        public IActionResult OnGet()
        {
            try
            {
                // Verification.  
                if (this.User.Identity.IsAuthenticated)
                {
                    // Home Page.  
                    return this.RedirectToPage("/Home/Index");
                }
            }
            catch (Exception ex)
            {
                // Info  
                Console.Write(ex);
            }

            // Info.  
            return this.Page();
        }

        #region On Post Login method.  

        /// <summary>  
        /// POST: /Index/LogIn  
        /// </summary>  
        /// <returns>Returns - Appropriate page </returns>  
        public async Task<IActionResult> OnPostLogIn()
        {
            try
            {
                // Verification.  
                if (ModelState.IsValid)
                {
                    // Initialization.  
                    /*var loginInfo = await this.databaseManager.LoginByUsernamePasswordMethodAsync(this.LoginModel.Username, this.LoginModel.Password);

                    // Verification.  
                    if (loginInfo != null && loginInfo.Count() > 0)
                    {
                        // Initialization.  
                        var logindetails = loginInfo.First();

                        // Login In.  
                        await this.SignInUser(logindetails.Username, false);

                        // Info.  
                        return this.RedirectToPage("/Home/Index");
                    }
                    else
                    {
                        // Setting.  
                        ModelState.AddModelError(string.Empty, "Invalid username or password.");
                    }*/
                   
                    return this.RedirectToPage("/Login");
                }
                else
                {
                    return this.RedirectToPage("/Register");
                }
            }
            catch (Exception ex)
            {
                // Info  
                Console.Write(ex);
            }

            // Info.  
            return this.Page();
=======
        [BindProperty]
        public User user { get; set; }

        [BindProperty(SupportsGet = true, Name = "ai_user")]
        public String userString { get; set; }

        public void OnGet()
        {

            //HttpContext.Session.Set("User", Encoding.UTF8.GetBytes(user.ToString()));
            //this.SignIn();
>>>>>>> 251a9927f50b1c09605ea1e3de17ca610e81e5c6
        }

        #endregion
    }
}
