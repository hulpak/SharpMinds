using System.Collections.Generic;

namespace HRM.DAL.Models
{
    public class User : BaseModel
    {
        public User()
        {
            UserDocuments = new HashSet<UserDocument>();
            UserRequests = new HashSet<UserRequest>();
            Roles = new HashSet<Role>();
            Teams = new HashSet<Team>();
        }
        public  string FullName { get; set; }
        public  string Password { get; set; }
        public  string Email { get; set; }
        public  System.DateTime? StartDate{ get; set; } 
        public  int StatusId { set; get;}
        public  int LevelId { set; get; }
        public  int UserRole { set; get; }
        public  int UserTeam { set; get; }

        public virtual UserLevel UserLevel { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<UserDocument> UserDocuments { get; set; }
        public virtual ICollection<UserRequest> UserRequests { get; set; } 
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<Team> Teams { get; set; }

    }
}
