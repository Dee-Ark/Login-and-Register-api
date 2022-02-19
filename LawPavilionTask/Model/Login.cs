using System.ComponentModel.DataAnnotations;

namespace LawPavilionTask.Model
{
    public class Login
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? email { get; set; }
        [Required]
        public string? password { get; set; }
    }
}
