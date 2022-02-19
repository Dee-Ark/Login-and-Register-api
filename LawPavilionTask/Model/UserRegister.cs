using System.ComponentModel.DataAnnotations;

namespace LawPavilionTask.Model
{
    public class UserRegister
    {
        [Key]
        public int Id { get; set; }
        [Required]
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
        public DateTime createdDate { get; set; }
    }
}
