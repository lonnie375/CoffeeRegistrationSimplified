using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace CoffeeRegistrationSimplified.Models
{
    public class Register
    {
        public int Id { get; set; }

        //First Name 
        [Required]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }

        //Last Name 
        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        //Email Address 
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        //Password 
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //Confirm Password
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [NotMapped]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
