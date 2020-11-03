using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DATA.EF
{
    public class EnrollmentMetaData
    {
        [Required(ErrorMessage = "* Student is REQUIRED")]
        [Display(Name = "Student")]
        public int StudentId { get; set; }
        [Required(ErrorMessage = "* Scheduled Class is REQUIRED")]
        [Display(Name = "Scheduled Class")]
        public int ScheduledClassId { get; set; }
        [Display(Name = "Enrollment Date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "* Enrollment Date is REQUIRED")]
        public System.DateTime EnrollmentDate { get; set; }
    }

    [MetadataType(typeof(EnrollmentMetaData))]
    public partial class Enrollment{

    }
}
