using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Models
{
    public class UserLevel:BaseModel
    {
        public UserLevel() {
            Users = new HashSet<User>();
        }
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }

    }
}
