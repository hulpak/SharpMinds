using HRM.DAL.Models;
using System.Data.Entity.ModelConfiguration;
namespace HRM.DAL
{
    public class UserLevelMap : EntityTypeConfiguration<UserLevel>
    {
        public UserLevelMap()
        {
            ToTable("UserLevel", "hrm").HasKey(t => t.Id);
            Property(t => t.Name).HasMaxLength(128).IsRequired();           
        }
    }
}
