using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DATA.EF
{
    [MetadataType(typeof(CourseMetaData))]
    public partial class Cours
    {

    }

    public class CourseMetaData
    {
        [Required]
        [Display(Name = "Course ID")]
        public int CourseId { get; set; }

        [Required]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [Display(Name = "Description")]
        public string CourseDescription { get; set; }

        [Required]
        [Display(Name = "Credit Hours")]
        public byte CreditHours { get; set; }

        public string Curriculum { get; set; }

        public string Notes { get; set; }

        [Required]
        [Display(Name = "Is Active?")]
        public bool IsActive { get; set; }

    }
}
