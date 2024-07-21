using System.ComponentModel.DataAnnotations;

namespace CompetitionManagement.Models
{
    public class Competition
    {

        [Key]
        [Required]
        public int Id { get; set; }

        [MaxLength(200)]
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        public DateTime playDate { get; set; }

        [Required]
        public List<User> scoringCoach { get; set; }

        [Required]
        [Range(0, 20)]
        public int midScore { get; set; }
    }
}
