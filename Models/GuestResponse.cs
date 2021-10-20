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
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name should have at least 3 characters and no more than 100")]
        //[RegularExpression(".{3,100}", ErrorMessage = "Name should have at least 3 characters and no more than 100")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your phone")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress (ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required]
        public bool? WillAttend { get; set; }

    }
}
