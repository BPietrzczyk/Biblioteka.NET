using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projekt_Biblioteka.Data;
using Projekt_Biblioteka.Models;

namespace Projekt_Biblioteka.Pages
{
    public class Register : PageModel
    {
        private readonly ApplicationDbContext _db;

        public Register(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<User> users { get; set; }
        [BindProperty]
        public User user { get; set; }
        [BindProperty]
        public String password2 { get; set; }

        public async Task OnGet()
        {
            users = await _db.User.ToListAsync();
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                // dodaæ sprawdzenie czy u¿ytkownicy siê nie powtarzaj¹
                bool userExistInDatabase = false;
                bool changeLogin = false;
                bool changeEmail = false;

                users = await _db.User.ToListAsync();

                foreach (User u in users)
                {
                    if (u.Login == user.Login)
                    {
                        changeLogin = true;
                        break;
                    }
                    if (u.Email == user.Email)
                    {
                        changeEmail = true;
                        break;
                    }
                }

                if (changeEmail || changeLogin)
                    userExistInDatabase = true;
                

                if (!userExistInDatabase)
                {
                    if (password2.Equals(user.Password))
                    {
                        await _db.User.AddAsync(user);
                        await _db.SaveChangesAsync();
                        return RedirectToPage("Index");
                    } else
                    {
                        return Page();
                    }
                    
                }
                else
                    return Page();


            } else
            {
                return Page();
            }

        }
    }
}
