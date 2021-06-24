using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SAT.UI.Secured.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "You Idiot, how did you mess this up?")]
        public string Name { get; set; }

        public string Subject { get; set; }

        [Required(ErrorMessage = "You Idiot, this one is also requried")]
        [EmailAddress(ErrorMessage = "You Idiot, How even? Like for reals. It says EMAIL ADDRESS")]
        [Display(Name = "Your Email Address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "You Idiot, I can't even right now.")]
        [UIHint("MultilineText")] //This formats the input field as a text area
        public string Message { get; set; }
    }
}