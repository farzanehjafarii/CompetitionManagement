namespace CompetitionManagement.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string title { get; set; }

        public ServiceRole? serviceRole { get; set; }

        public virtual ICollection<User_Role>? User_Role { get; set; }
    }
    public enum ServiceRole
    {
        admin=1,
        coach=2,
        player=3
    }
}
