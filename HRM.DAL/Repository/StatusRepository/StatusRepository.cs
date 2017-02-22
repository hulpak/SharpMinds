using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRM.DAL.Models;
using HRM.DAL.DbContext;

namespace HRM.DAL.Repository.StatusRepository
{
    public  class StatusRepository : Repository<Status>, IStatusRepository
    {
       public  HRMContext db;
        public StatusRepository(HRMContext context) : base(context)
		{
            db = context;
        }

        public Status GetStatusById(int Id)
        {
            return db.Statuses
                .Where(e => e.Id == Id).FirstOrDefault<Status>();
        }
   
       
    }
}

