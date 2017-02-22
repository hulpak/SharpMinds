using HRM.DAL.Models;
using System.Data.Entity.ModelConfiguration;

namespace HRM.DAL.EF
{
   public class StatusMap : EntityTypeConfiguration<Status>
    {
        public StatusMap()
        {
            ToTable("Status", "hrm").HasKey(t => t.Id);
            Property(t => t.Name).HasMaxLength(128).IsRequired();
            Property(e => e.StatusTypeId).IsRequired();
        }

    }
}
