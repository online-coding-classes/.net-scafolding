using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Firstname is required.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Lastname is required.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Phone is required.")]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Phone number must be in the format (999-999-9999).")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string? Password { get; set; }
        [Compare("Password", ErrorMessage = "Password and confirmation password do not match.")]
        public string? ConfirmPassword { get; set; }

        public User() { }
    }
}
