using System.ComponentModel.DataAnnotations;

namespace BackendServiceStarter.Models
{
    public class User
    {
        public int Id { get; set; }
        
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        
        [Required]
        public string Password { get; set; }
        
        [Required]
        public UserRole Role { get; set; }
    }
}