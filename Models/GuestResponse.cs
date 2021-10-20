using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class GuestResponse
    {

        [Required (ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public bool? WillAttend { get; set; }

    }
}
