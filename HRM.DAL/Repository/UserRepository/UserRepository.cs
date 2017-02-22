using HRM.DAL.Models;
using HRM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRM.DAL.DbContext;

namespace HRM.DAL
{
    public class UserRepository : Repository<User>,IUserRepository
    {
        public HRMContext db;
        public UserRepository(HRMContext context) : base(context)
		{
            db = context;
        }
        public User GetByCredentials(string email, string password)
        {
            return db.Users
                .Where(e => e.Email == email && e.Password == password)
                .FirstOrDefault();
        }
        public User GetByEmail(string email)
        {
            return db.Users
                .Where(e => e.Email == email)
                .FirstOrDefault<User>();
        }
        public IEnumerable<User> GetHR()
        {
            return db.Users.Where(c => c.Roles.Any(t => t.Id == 3));
        }

        public IEnumerable<User> GetTeamLead()
        {
            return db.Users.Where(c => c.Roles.Any(t => t.Id == 2));
        }
    }
}
