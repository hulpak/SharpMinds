using System.Collections.Generic;

namespace HRM.DAL.Models
{

    public class Role : BaseModel
    {
        public Role() {
            Users = new HashSet<User>();
        }
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }

}



