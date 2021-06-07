using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projekt_Biblioteka.Data;
using Projekt_Biblioteka.Models;

namespace Projekt_Biblioteka.Pages.Profile
{
    public class ResetPasswordModel : PageModel
    {

        [BindProperty]
        public User user { get; set; }
        public IEnumerable<User> users { get; set; }



        private readonly ApplicationDbContext _db;
        public ResetPasswordModel(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPost(string email)
        {
            users = await _db.User.ToListAsync();

            foreach (User u in users)
            {
                if (u.Email == email)
                {
                    u.Password = RandomString(8);
                    await _db.SaveChangesAsync();

                    sendEmail(u.Password, u.Email);

                    return new RedirectToPageResult("../Index");
                }
            }



            return new RedirectToPageResult("../Index");
        }




        private bool sendEmail(string password, string toUserEmail)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("botprojektdiscord@gmail.com");
                mail.To.Add(toUserEmail);
                mail.Subject = "Nowe haslo do Biblioteki";
                mail.Body = $"Nowe haslo to:{password}";

                



                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net
                    .NetworkCredential("botprojektdiscord@gmail.com".Substring(0, "botprojektdiscord@gmail.com".IndexOf('@')), "bardzosilnehaslo");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }



        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}
