using HRM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.EF
{
    public class UserRequestMap : EntityTypeConfiguration<UserRequest>
    {
        public UserRequestMap()
        {
            ToTable("Request", "hrm").HasKey(t => t.Id);
            Property(t => t.UserId).IsRequired();
            Property(t => t.RequestTypeId).IsRequired();
            Property(t => t.StartDate).IsRequired();
            Property(t => t.EndDate).IsRequired();
            Property(t => t.StatusId).IsRequired();
            HasRequired(e => e.RequestType);//one to one
        }
    }
}
