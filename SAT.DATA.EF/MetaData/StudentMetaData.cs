using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DATA.EF
{
    public class StudentMetaData
    {
        [Required(ErrorMessage = "* First Name is REQUIRED")]
        [Display(Name = "First Name")]
        [StringLength(20, ErrorMessage = "* First Name can only be a max of 20 characters.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "* Last Name is REQUIRED")]
        [Display(Name = "Last Name")]
        [StringLength(20, ErrorMessage = "* Last Name can only be a max of 20 characters.")]
        public string LastName { get; set; }
        [StringLength(15, ErrorMessage = "* Majors can only be a max of 15 characters.")]
        public string Major { get; set; }
        [StringLength(50, ErrorMessage = "* Address can only be a max of 50 characters.")]
        public string Address { get; set; }
        [StringLength(25, ErrorMessage = "* City can only be a max of 25 characters.")]
        public string City { get; set; }
        [StringLength(2, ErrorMessage = "* State can only be a max of 2 characters.")]
        public string State { get; set; }
        [StringLength(60, ErrorMessage = "* Zipcode can only be a max of 60 characters.")]
        [Display(Name = "Zip code")]
        public string ZipCode { get; set; }
        [StringLength(13, ErrorMessage = "* Phone can only be a max of 13 characters.")]
        public string Phone { get; set; }
        [StringLength(60, ErrorMessage = "* Email can only be a max of 60 characters.")]
        [Required(ErrorMessage = "* Email is REQUIRED")]
        public string Email { get; set; }
        [Display(Name = "Phone URL")]
        [StringLength(100, ErrorMessage = "* Phone URL can only be a max of 100 characters.")]
        public string PhoneUrl { get; set; }
        [Required(ErrorMessage = "* Student Status is REQUIRED")]
        [Display(Name = "Student Status")]
        public int SSID { get; set; }
    }

    [MetadataType(typeof(StudentMetaData))]
    public partial class Student
    {
        public string studentFullname
        {
            get { return ($"{FirstName} {LastName}"); }
        }
    }
}
