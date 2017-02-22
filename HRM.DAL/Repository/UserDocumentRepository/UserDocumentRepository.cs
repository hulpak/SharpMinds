using System;
using HRM.DAL.Models;
using HRM.DAL;
using System.Linq;
using HRM.DAL.DbContext;
using HRM.DAL.Repository.UserDocumentRepository;

namespace HRM.DAL.Repository.TeamRepository
{
    public class UserDocumentRepository :Repository<UserDocument>,IUserDocumentRepository
    {
        public HRMContext db;
        public UserDocumentRepository(HRMContext context) : base(context)
		{
            db = context;
        }

        public UserDocument GetByEmail(string link)
        {
            return db.UserDocuments.Where(t => t.DocumentLink == link).FirstOrDefault();
        }
    }
}
