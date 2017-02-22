using HRM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Repository.RequestTypeRepository
{
    interface IRequestTypeRepository:IRepository<RequestType>
    {
        UserRequest GetUserRequestTypeByName(string Name);
    }
}
