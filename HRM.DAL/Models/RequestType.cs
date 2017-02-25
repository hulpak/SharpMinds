using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Models
{
    public class RequestType : BaseModel
    {
        public RequestType()
        {
            UserRequests = new HashSet<UserRequest>();
        }
        public string Name { get; set; }
        public virtual ICollection<UserRequest> UserRequests { get; set; }
    }
}
