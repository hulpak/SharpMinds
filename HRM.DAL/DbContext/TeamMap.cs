using HRM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.DbContext
{
    public class TeamMap : EntityTypeConfiguration<Team>
    {
        public TeamMap()
        {
            ToTable("Team", "hrm").HasKey(t => t.Id);
            Property(t => t.Name).HasMaxLength(128).IsRequired();
            
        }

    }
}
