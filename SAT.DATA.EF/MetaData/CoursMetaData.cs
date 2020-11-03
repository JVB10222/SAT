using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DATA.EF
{
    public class CoursMetaData
    {
        [Required(ErrorMessage = "* Course Name is REQUIRED")]
        [Display(Name = "Course Name")]
        [StringLength(50, ErrorMessage = "* Course Name can only be a max of 50 characters.")]
        public string CourseName { get; set; }
        [Required(ErrorMessage = "* Course Description is REQUIRED")]
        [Display(Name = "Course Description")]
        public string CourseDescription { get; set; }
        [Display(Name = "Credit Hours")]
        [Required(ErrorMessage = "* Credit Hours is REQUIRED")]
        public byte CreditHours { get; set; }
        [StringLength(250, ErrorMessage = "* Curriculum can only be a max of 250 characters.")]
        [Display(Name = "Curriculum")]
        public string Currirculum { get; set; }
        [StringLength(500, ErrorMessage = "* Notes con only be a max of 500 characters.")]
        public string Notes { get; set; }
        [Required(ErrorMessage = "* Is Active is REQUIRED")]
        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }
    }

    [MetadataType(typeof(CoursMetaData))]
    public partial class Cours {

    }
}
