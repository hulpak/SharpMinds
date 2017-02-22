using System;
using HRM.DAL.Models;
using HRM.DAL;
using System.Linq;
using HRM.DAL.DbContext;

namespace HRM.DAL.Repository.TeamRepository
{
    public class TeamRepository :Repository<Team>, ITeamRepository
    {
        public HRMContext db;
        public TeamRepository(HRMContext context) : base(context)
		{
            db = context;
        }
        public Team GetTeamById(int? Id)
        {
            return db.Teams
                .Where(e => e.Id == Id).FirstOrDefault();
        }
        public override void Delete(Team team)
        {
            db.Users.RemoveRange(team.Users);
            db.Teams.Remove(team);

        }
        public void DeleteMembers(Team team,User user)
        {
            db.Users.Remove(user);
            db.Teams.Find(team.Id).Users.Remove(db.Users.Find(user.Id));

        }
    }
}
