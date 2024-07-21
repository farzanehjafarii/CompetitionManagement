namespace CompetitionManagement.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int numberOfSuccess { get; set; }
        public int numberOfFailur { get; set; }


        public virtual ICollection<User_Team>? User_Team { get; set; }

    }
}
