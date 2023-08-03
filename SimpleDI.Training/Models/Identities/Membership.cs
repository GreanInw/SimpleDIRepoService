using System.ComponentModel.DataAnnotations;

namespace SimpleDI.Training.Models.Identities
{
    internal class Membership
    {
        [Key]
        public Guid Id { get; set; }
        [Required, MaxLength(255)]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
