using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DATA.EF
{
    [MetadataType(typeof(StudentMetaData))]
    public partial class Student { }

    public class StudentMetaData
    {
        [Required]
        [Display(Name = "Student ID")]
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        
        public string Major { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [Display(Name ="State: 2 digit code")]
        public string State { get; set; }

        [Required]
        [Display(Name ="Zip Code")]
        public string ZipCode { get; set; }

        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }
      
        public string PhotoUrl { get; set; }

        [Required]
        public int SSID { get; set; }
    }
}
