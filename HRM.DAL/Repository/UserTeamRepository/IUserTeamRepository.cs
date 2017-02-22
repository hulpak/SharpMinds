using HRM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Repository.UserTeamRepository
{
    interface IUserTeamRepository:IRepository<UserTeam>
    {
        UserTeam GetUserTeamByTeamId(int Id);
    }
}
