using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projekt_Biblioteka.Data;
using Projekt_Biblioteka.Models;

namespace Projekt_Biblioteka.Pages.registerErrors
{
    public class REmail : PageModel
    {

        private readonly ApplicationDbContext _db;

        public REmail(ApplicationDbContext db)
        {
            _db = db;
            userExistInDatabase = false;
            ChangeLogin = false;
            changeEmail = false;
        }

        public IEnumerable<User> users { get; set; }
        [BindProperty]
        public User user { get; set; }
        [BindProperty]
        public String password2 { get; set; }
        

        bool userExistInDatabase;
        private bool _changeLogin;
        [BindProperty]
        public bool ChangeLogin { get; set; }
        bool changeEmail;

        public async Task OnGet()
        {
            users = await _db.User.ToListAsync();
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                //throw new ArgumentException($"Uzytkownik z tym loginem juz istnieje {userExistInDatabase}");
                
                // doda� sprawdzenie czy u�ytkownicy si� nie powtarzaj�


                users = await _db.User.ToListAsync();

                foreach (User u in users)
                {
                    if (u.Login == user.Login)
                    {
                        //throw new ArgumentException("Uzytkownik z tym loginem juz istnieje");
                        ChangeLogin = true;
                        break;
                    }
                    if (u.Email == user.Email)
                    {
                        changeEmail = true;
                        break;
                    }
                }

                if (changeEmail || ChangeLogin)
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
