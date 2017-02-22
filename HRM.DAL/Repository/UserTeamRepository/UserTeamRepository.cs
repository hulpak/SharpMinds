using HRM.DAL.DbContext;
using HRM.DAL.Models;
using HRM.DAL.Repository.UserTeamRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL
{
    public class UserTeamRepository : Repository<UserTeam>, IUserTeamRepository
    {
        public HRMContext db;
        public UserTeamRepository(HRMContext context) : base(context) {
            db = context;
        }
        public UserTeam GetUserTeamByTeamId(int Id)
        {
            return db.UserTeams.Where(t => t.TeamId == Id).FirstOrDefault();
        }
    }
}
