using HRM.DAL.DbContext;
using HRM.DAL.Models;
using System.Linq;

namespace HRM.DAL.Repository.RoleRepository
{
    public class RoleRepository:Repository<Role>, IRoleRepository
    {
        public HRMContext db;
        public RoleRepository(HRMContext context) : base(context)
		{
            db = context;
    }
    public Role GetRoleById(int Id)
    {
        return db.Roles
            .Where(e => e.Id == Id).FirstOrDefault();
    }
         
    }
}
