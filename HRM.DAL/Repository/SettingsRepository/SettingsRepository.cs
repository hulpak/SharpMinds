using HRM.DAL.DbContext;
using HRM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL
{
    public class SettingsRepository : Repository<Settings>, ISettingsRepository
    {
        public HRMContext db;
        public SettingsRepository(HRMContext context) : base(context)
        {
            db = context;
        }

    }
}
