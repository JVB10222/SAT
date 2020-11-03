using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DATA.EF
{
    public class ScheduledClassMetaData
    {

        [Required(ErrorMessage = "* Course is REQUIRED")]
        [Display(Name = "Course")]
        public int CourseId { get; set; }
        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public System.DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public System.DateTime EndDate { get; set; }
        [StringLength(40, ErrorMessage = "* Instructor can only be a max of 40 characters.")]
        [Required(ErrorMessage = "* Instructor is REQUIRED")]
        [Display(Name = "Instructor Name")]
        public string InstructorName { get; set; }
        [StringLength(20, ErrorMessage = "* Location can only be a max of 20 characters.")]
        [Required(ErrorMessage = "* Location is REQUIRED")]
        public string Location { get; set; }
        [Display(Name = "Scheduled Class Status")]
        [Required(ErrorMessage = "* Scheduled Class Status is REQUIRED")]
        public int SCSID { get; set; }

    }

    [MetadataType(typeof(ScheduledClassMetaData))]
    public partial class ScheduledClass
    {
        [Display(Name = "Scheduled Class: ")]
        public string ScheduledClassString
        {
            get { return ($"Start Date: {StartDate:d}, Course Name: {Cours.CourseName}, Location: {Location}") ; }
        }
    }
}
