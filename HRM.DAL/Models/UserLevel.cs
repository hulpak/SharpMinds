using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Models
{
    public class UserLevel:BaseModel
    {
        public string Name { get; set; }
        public virtual User User { get; set; }       
    }
}
