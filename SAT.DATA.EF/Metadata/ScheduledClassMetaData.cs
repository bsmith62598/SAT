using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DATA.EF
{
    [MetadataType(typeof(ScheduledClassMetaData))]
    public partial class ScheduledClass
    {
        public string ClassDesc
        {
            get
            {
                return StartDate + " " + Cours.CourseName + " " + Location;
            }
        }
    }

    public class ScheduledClassMetaData
    {
        [Required]
        [Display(Name ="Scheduled Class ID")]
        public int ScheduledClassId { get; set; }

        [Required]
        [Display(Name ="Course ID")]
        public int CourseId { get; set; }

        [Required]
        [Display(Name ="Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Required]
        [Display(Name ="Instructor Name")]
        public string InstructorName { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public int SCSID { get; set; }
    }
}
