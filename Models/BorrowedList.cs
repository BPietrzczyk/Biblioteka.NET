using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Biblioteka.Models
{
    public class BorrowedList
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int BookId { get; set; }
        public int UserId { get; set; }
    }
}
