using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Models
{
    public class Settings :BaseModel
    {
        public int SickDays { get; set; }
        public int VacationDays { get; set; }
    }
}
