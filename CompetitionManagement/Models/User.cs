using Microsoft.AspNetCore.Routing;

namespace CompetitionManagement.Models
{
    public class User
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string email { get; set; }   
        public string passWord { get; set; }
        public string mobile { get; set; }
        public string name { get; set; }
        public string family { get; set; }
        public virtual ICollection<User_Team>? User_Team { get; set; }
        public virtual ICollection<User_Role>? User_Role { get; set; }





    }

}
