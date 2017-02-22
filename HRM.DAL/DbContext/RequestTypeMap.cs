using HRM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.EF
{
    public class RequestTypeMap : EntityTypeConfiguration<RequestType>
    {
        public RequestTypeMap()
        {
            ToTable("RequestType", "hrm").HasKey(t => t.Id);
            Property(t => t.Name).HasMaxLength(128).IsRequired();


        }
    }
}
