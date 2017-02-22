using HRM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.DbContext
{
    public class UserRoleMap : EntityTypeConfiguration<UserRole>
    {
        public UserRoleMap()
        {
            this.ToTable("UserRole", "hrm");
            this.HasKey(t => t.RoleId);
            this.HasKey(t => t.UserId);
        }
     
    }
}
