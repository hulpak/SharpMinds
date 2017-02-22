using System;
using HRM.DAL.Models;
using HRM.DAL;
using System.Linq;
using HRM.DAL.DbContext;

namespace HRM.DAL.Repository.TeamRepository
{
  
    public class RequestTypeRepository : Repository<RequestType>
    {
        private HRMContext dbContext;
        public RequestTypeRepository(HRMContext context) : base(context)
        {
            dbContext = context;
        }
        public UserRequest GetUserRequestTypeByName(string Name)
        {
            return dbContext.Requests
                .Where(e => e.RequestType.Name == Name).FirstOrDefault();

        }

    }
}
    

