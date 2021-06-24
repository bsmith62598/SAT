using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DATA.EF
{
    class StudentStatusMetaData
    {
        [Required]
        [Display(Name = "SSID")]
        public int SSID { get; set; }

        [Required]
        [Display(Name = "SS Name")]
        public string SSName { get; set; }

        [Required]
        [Display(Name = "SS Description")]
        public string SSDescription { get; set; }

    }
}
