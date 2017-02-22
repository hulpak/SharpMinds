using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRM.DAL.Models;
using HRM.DAL.DbContext;

namespace HRM.DAL.Repository.StatusTypeRepository
{
    public class StatusTypeRepository : Repository<StatusType>, IStatusTypeRepository
    {
        public HRMContext db;
        public StatusTypeRepository(HRMContext context) : base(context)
		{
            db = context;
        }    

        public StatusType GetStatusTypeByName(string name)
        {
            return db.StatusTypes
                .Where(e => e.Name == name).FirstOrDefault<StatusType>();
        }

    }
}
