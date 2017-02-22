using System;
using HRM.DAL.Models;
using HRM.DAL;
using System.Linq;
using HRM.DAL.Repository.UserRequestRepository;
using HRM.DAL.DbContext;

namespace HRM.DAL.Repository.TeamRepository
{
    public class UserRequestRepository : Repository<UserRequest>, IUserRequestRepository
    {
        public HRMContext db;
        public UserRequestRepository(HRMContext context) : base(context)
        {
            db = context;
        }

        public UserRequest GetUserRequestTypeByStartDate(DateTime date)
        {
            return db.Requests.Where(t => t.StartDate == date).FirstOrDefault();
        }
    }
  
}
