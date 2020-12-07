using System.ComponentModel.DataAnnotations;

namespace MemberDemo.Models.Classes
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }


        [Required(ErrorMessage = "Full NAme Is Required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Full NAme Is Required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Email NAme Is Required")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string AdminEmail { get; set; }


        [Required(ErrorMessage = "Password NAme Is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
