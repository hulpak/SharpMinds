using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Models
{
    public class Status : BaseModel
    {
       public string Name { get; set; }
       public int StatusTypeId { get; set; }

        public virtual StatusType status { get; set; }
        public virtual User User { get; set; }

    }
}
