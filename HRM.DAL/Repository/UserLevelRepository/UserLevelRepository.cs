using HRM.DAL.DbContext;
using HRM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Repository.UserLevelRepository
{
    public class UserLevelRepository:Repository<UserLevel>,IUserLevelRepository
    {
        public HRMContext db;
        public UserLevelRepository(HRMContext context) : base(context) {
            db = context;
        }

        public UserLevel GetUserLevelByName(string Name)
        {
            return db.UserLevels.Where(t => t.Name == Name).FirstOrDefault();
        }
    }
}
