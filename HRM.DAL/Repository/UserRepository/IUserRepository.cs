using HRM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL
{
    public interface IUserRepository: IRepository<User>
    {
        User GetByCredentials(string email, string password);
        User GetByEmail(string email);
        IEnumerable<User> GetTeamLead();
        IEnumerable<User> GetHR();

    }
}
