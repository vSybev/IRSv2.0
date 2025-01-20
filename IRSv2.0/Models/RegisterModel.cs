using System.ComponentModel.DataAnnotations;

namespace IRSv2._0.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters.")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Position is required.")]
        [StringLength(50, ErrorMessage = "Position cannot exceed 50 characters.")]
        public required string Position { get; set; }

        [Required(ErrorMessage = "ID is required.")]
        [StringLength(10, ErrorMessage = "ID cannot exceed 10 characters.")]
        public required string Id { get; set; }

        [Required(ErrorMessage = "Phone Number is required.")]
        [Phone(ErrorMessage = "Invalid phone number format.")]
        public string? PhoneNumber { get; set; }
    }
}
