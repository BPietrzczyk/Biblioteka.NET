using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Biblioteka.Models
{
    public class LoginViewModel
    {
        #region Properties
        [Required]
        [Display(Name ="Login")]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Password")]
        public string Password { get; set; }

        #endregion
    }
}
