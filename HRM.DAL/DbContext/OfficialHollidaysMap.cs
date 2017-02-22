using HRM.DAL.Models;
using System.Data.Entity.ModelConfiguration;




namespace HRM.DAL.EF
{
    class OfficialHollidaysMap: EntityTypeConfiguration<OfficialHollidays>
    {
        public OfficialHollidaysMap()
        {
            ToTable("OfficialHollidays", "hrm").HasKey(t => t.Id);
            Property(t => t.Date).IsRequired();
        }
    }
}
