using System.ComponentModel.DataAnnotations;

namespace ValidationAttributtes.Models
{
    public class Student
    {
        //[Required]
        [Required(ErrorMessage ="Name is Must")]//Custom error Message
        [StringLength(15, MinimumLength =3, ErrorMessage ="Name must be within 3 to 15 characters.")]
        public string  Name { get; set; }

        [Required(ErrorMessage = "Email is Must")]
        //[EmailAddress] Not Working For Email Address
        //Check Valid Email Address
        [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$",ErrorMessage ="Invalid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age is Must")]
        [Range(10,50,ErrorMessage ="Age must be within 10 to 50")]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Password is Must")]
        //Minimum eight characters, at least one uppercase letter, one lowercase letter, one number and one special character
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$", ErrorMessage = "Minimum eight characters, at least one uppercase letter, one lowercase letter, one number and one special character")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Phone Number is Must")]
        //Bangladeshi Mobile Number Check
        [RegularExpression("(^(\\+88|0088)?(01){1}[3456789]{1}(\\d){8})$", ErrorMessage ="Invalid Mobile Number")]
        public string PNumber{ get; set; }
    }
}
