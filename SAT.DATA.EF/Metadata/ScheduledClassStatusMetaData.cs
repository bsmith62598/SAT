using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DATA.EF
{
    class ScheduledClassStatusMetaData
    {
        [Required]
        [Display(Name = "SCSID")]
        public int SCSID { get; set; }

        [Required]
        [Display(Name = "SCS Name")]
        public string SCSName { get; set; }
    }
}
