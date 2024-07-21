using System.ComponentModel.DataAnnotations;

namespace CompetitionManagement.Models
{
    public class User_Team
    {
        [Key]
        [Required]
        public int userId { get; set; }

        [Key]
        [Required]
        public int teamId { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public User? user { get; set; }
        public Team? team { get; set; }
    }
}
