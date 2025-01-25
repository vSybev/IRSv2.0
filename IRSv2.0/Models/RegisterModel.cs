using System.ComponentModel.DataAnnotations;

namespace IRSv2._0.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters.")]
        [RegularExpression(@"^[^\d]+$", ErrorMessage = "Name cannot contain numbers.")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Position is required.")]
        [StringLength(50, ErrorMessage = "Position cannot exceed 50 characters.")]
        public required string Position { get; set; }

        [Required(ErrorMessage = "ID is required.")]
        [RegularExpression(@"^[MSCHWD]{1}[0-9]+$", ErrorMessage = "ID must start with one of the following letters: M, S, C, H, W, D, followed by at least one digit.")]
        public required string Id { get; set; }

        [Required(ErrorMessage = "Phone Number is required.")]
        [RegularExpression(@"^\+?[0-9]+$", ErrorMessage = "Phone number can only contain digits and an optional leading '+'.")]
        public string? PhoneNumber { get; set; }
    }
}
