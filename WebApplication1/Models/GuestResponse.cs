using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please enter your name")]
        public string Name{get; set;}
        [Required(ErrorMessage = "Please enter your email")]
        [RegularExpression(@".+\@.+\..+",ErrorMessage = "Please enter your name")]
        public string Email{ get; set; }
        [Required(ErrorMessage = "phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "attend")]
        public bool? WillAttend { get; set; }

    }
}