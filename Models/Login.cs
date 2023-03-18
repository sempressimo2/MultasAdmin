using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MultasAdmin.Models
{
    public class Login
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [MaxLength(255)]
        public string PasswordHash { get; set; }

        [Required]
        [MaxLength(100)]
        public string Role { get; set; }

        // Add any additional properties you may need for the Login model
    }
}
