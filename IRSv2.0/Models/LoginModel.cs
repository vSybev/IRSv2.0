using System.ComponentModel.DataAnnotations;

namespace IRSv2._0.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "ID is required.")]
        [StringLength(10, ErrorMessage = "ID cannot exceed 10 characters.")]
        public string Id { get; set; }
    }
}
