using HRM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL
{
    public interface IOfficialHollidaysRepository : IRepository<OfficialHollidays>
    {
        OfficialHollidays GetOffHolldayByID(int Id);

    }
}
