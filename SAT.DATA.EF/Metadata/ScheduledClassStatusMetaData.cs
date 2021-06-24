using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DATA.EF
{
    [MetadataType(typeof(ScheduledClassStatusMetaData))]
    public partial class ScheduledClassStatus { }

    public class ScheduledClassStatusMetaData
    {
        [Required]
        public int SCSID { get; set; }

        [Required]
        [Display(Name="SCS Name")]
        public int SCSName { get; set; }
    }
}
