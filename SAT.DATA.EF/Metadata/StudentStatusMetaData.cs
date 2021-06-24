using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DATA.EF
{
    [MetadataType(typeof(StudentStatusMetaData))]
    public partial class StudentStatus { }

    class StudentStatusMetaData
    {
        [Required]
        public int SSID { get; set; }

        [Required]
        [Display(Name ="SS Name")]
        public string SSName { get; set; }

        [Required]
        [Display(Name = "SS Description")]
        public string SSDescription { get; set; }
    }
}
