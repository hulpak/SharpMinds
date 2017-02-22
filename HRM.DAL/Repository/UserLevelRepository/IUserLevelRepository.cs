using HRM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Repository.UserLevelRepository
{
    interface IUserLevelRepository:IRepository<UserLevel>
    {
        UserLevel GetUserLevelByName(string Name);
    }
}
