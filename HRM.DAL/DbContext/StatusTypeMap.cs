using HRM.DAL.Models;
using System.Data.Entity.ModelConfiguration;

namespace HRM.DAL.EF
{
    public class StatusTypeMap : EntityTypeConfiguration<StatusType>
    {
        public StatusTypeMap()
 		{
            ToTable("StatusType", "hrm").HasKey(t => t.Id); 
 			Property(t => t.Name).HasMaxLength(128).IsRequired();
        }

    }
}
