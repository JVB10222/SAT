using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DATA.EF
{
    public class ScheduledClassStatusMetaData
    {
        [Required(ErrorMessage ="* Status is REQUIRED")]
        [StringLength(50, ErrorMessage = "* Status can only be a max of 50 characters.")]
        [Display(Name = "Status")]
        public string SCSName { get; set; }


    }

    [MetadataType(typeof(ScheduledClassStatusMetaData))]
    public partial class ScheduledClassStatus
    {
        
    }
}
