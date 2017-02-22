using HRM.DAL.DbContext;
using HRM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Repository.UserRoleRepository
{
    public class UserRoleRepository:Repository<UserRole>, IUserRoleRepository
    {
        public HRMContext db;
        public UserRoleRepository(HRMContext context) : base(context) {
            db = context;
        }

        public UserRole GetUserRoleById(int id)
        {
            return db.UserRoles.Where(t => t.RoleId == id).FirstOrDefault();
        }
    }
}
