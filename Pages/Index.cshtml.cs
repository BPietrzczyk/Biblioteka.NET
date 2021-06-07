using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Projekt_Biblioteka.Data;
using Projekt_Biblioteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Biblioteka.Pages
{
    public class IndexModel : PageModel
    {
        public bool isUserLogged;

        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _db;

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext db)
        {
            _db = db;
            _logger = logger;
            isUserLogged = false;
        }

        public IEnumerable<Book> Books { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Books = await _db.Book.ToListAsync();
            if (!isUserLogged)
            {
                return this.RedirectToPage("/Login");
            }
            else
            {
                return this.Page();
            }
        }
    }
}
