using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Data
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Name must not include numbers or special characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }
    }
}
