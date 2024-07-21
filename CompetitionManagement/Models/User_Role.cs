using System.ComponentModel.DataAnnotations;

namespace CompetitionManagement.Models
{
    public class User_Role
    {
        [Key]
        [Required]
        public int userId { get; set; }

        [Key]
        [Required]
        public int roleId { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public User? user { get; set; }
        public Role? role { get; set; }

    }
}
