using HRM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Repository.StatusTypeRepository
{
    interface IStatusTypeRepository : IRepository<StatusType>
    {
        StatusType GetStatusTypeByName(string name);
    }
}