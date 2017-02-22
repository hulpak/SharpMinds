using HRM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Repository.StatusRepository
{
    interface IStatusRepository : IRepository<Status>
    {
        Status GetStatusById(int Id);
    }
}

    

