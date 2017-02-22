using HRM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Repository.UserDocumentRepository
{
    interface IUserDocumentRepository:IRepository<UserDocument>
    {
        UserDocument GetByEmail(string link);
    }
}
