using System.ComponentModel.DataAnnotations;

namespace LawPavilionTask.Model.DTO
{
    public class UserDto
    {
        public string? firstName { get; set; }
        [Required]
        public string? lastName { get; set; }
        [Required]
        public string? emailAddress { get; set; }
        [Required]
        public string? password { get; set; }
        [Required]
        public string? confirmPassword { get; set; }
        [Required]
        public string? phoneNumber { get; set; }
        [Required]
        public string? age { get; set; }
    }
}
