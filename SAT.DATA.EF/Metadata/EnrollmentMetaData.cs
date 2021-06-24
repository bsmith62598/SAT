using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DATA.EF
{
    [MetadataType(typeof(EnrollmentMetaData))]
    public partial class Enrollment
    {

    }

    public class EnrollmentMetaData
    {
        [Required]
        [Display(Name = "Enrollment ID")]
        public int EnrollmentId { get; set; }

        [Required]
        [Display(Name = "Student ID")]
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "Scheduled Class ID")]
        public int ScheduledClassId { get; set; }

        [Required]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        //[Required]
        //[Display(Name = "Scheduled Class")]
        //public ScheduledClass ScheduledClass { get; set; }

        //[Required]
        //public Student Student { get; set; }
    }
}
