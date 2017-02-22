using HRM.DAL.DbContext;
using HRM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL
{
   public class OfficialHollidaysRepository : Repository<OfficialHollidays>, IOfficialHollidaysRepository
    {
        private HRMContext dbContext;
        public OfficialHollidaysRepository(HRMContext context) : base(context)
        {
            dbContext = context;
        }


        public OfficialHollidays GetOffHolldayByID(int Id)
        {
            return dbContext.OfficialHollidayses.Where(e => e.Id == Id).FirstOrDefault<OfficialHollidays>();
  
        }
    }
}
