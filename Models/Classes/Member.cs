using MemberDemo.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace MemberDemo.Models.Classes
{
    public class Member
    {
        [Key]
        public int ID { get; set; }


        [Required(ErrorMessage = "Fisrt Name Field Is Required")]
        [Display(Name = "First Name")]
        [MaxLength(15, ErrorMessage = "First Name can't be more then 15 characters..."),
         MinLength(2, ErrorMessage = "First Name can't be less then 2 characters...")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Last Name Field Is Required")]
        [Display(Name = "Last Name")]
        [MaxLength(15, ErrorMessage = "Last Name can't be more then 15 characters..."),
         MinLength(2, ErrorMessage = "Last Name can't be less then 2 characters...")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Email Address Field Is Required")]
        [Display(Name = "Personal Email")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        [MaxLength(50, ErrorMessage = "Email can't be more then 50 characters..."),
         MinLength(11, ErrorMessage = "Email can't be less then 11 characters...")]
        [EmailAddress(ErrorMessage = "Example@domain.com")]
        public string Email { get; set; }


        [Display(Name = "Phone Number")]
        [Phone(ErrorMessage = "Please Enter a valid Phone Number")]
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = "Date Of Birth Field Is Required")]
        [Display(Name = "Date OF Birth")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOFBirth { get; set; }


        [Required(ErrorMessage = "Gender Field Is Required")]
        public Gender Gender { get; set; }


        [Required(ErrorMessage = "Country Field Is Required")]
        public Country Country { get; set; }


        [Required(ErrorMessage = "City Field Is Required")]
        public City City { get; set; }


        [Required(ErrorMessage = "Member Status Field Is Required")]
        [Display(Name = "Member Status")]
        public bool MemberStatus { get; set; }

        [MaxLength(200, ErrorMessage = "Max Length Shouldn't be More Then 200 characters")]
        public string Notes { get; set; }

        public string Photo { get; set; }
    }
}
