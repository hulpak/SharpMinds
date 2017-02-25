using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Models
{
    public class Status : BaseModel
    {
        public Status() {
            Users = new HashSet<User>();
            UserRequests = new HashSet<UserRequest>();
        }
       public string Name { get; set; }
       public int StatusTypeId { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<UserRequest> UserRequests { get; set; }
        public virtual StatusType StatusType { get; set; }


    }
}
