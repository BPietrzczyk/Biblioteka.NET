using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
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

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            isUserLogged = false;
        }

        public IActionResult OnGet()
        {
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
