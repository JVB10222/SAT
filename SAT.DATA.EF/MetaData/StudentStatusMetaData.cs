using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DATA.EF
{
    public class StudentStatusMetaData
    {
        [Required(ErrorMessage = "* Student Status is REQUIRED")]
        [Display(Name = "Student Status")]
        [StringLength(30, ErrorMessage = "* Student Status can only be a max of 30 characters.")]
        public string SSName { get; set; }
        [Display(Name = "Student Status Description")]
        [StringLength(250, ErrorMessage = "* Student Status Description can only be a max of 250 characters.")]
        public string SSDescription { get; set; }
    }

    [MetadataType(typeof(StudentStatusMetaData))]
    public partial class StudentStatus
    {
        
    }
}
