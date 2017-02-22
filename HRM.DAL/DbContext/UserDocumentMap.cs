using HRM.DAL.Models;
using System.Data.Entity.ModelConfiguration;

namespace HRM.DAL.EF
{
    public class UserDocumentMap : EntityTypeConfiguration<UserDocument>
    {
        public UserDocumentMap()
        {
            ToTable("UserDocument", "hrm").HasKey(t => t.Id);
            Property(t => t.DocumentLink).HasMaxLength(128).IsRequired();
            Property(t => t.UserId).IsRequired();
           

        }
    }
}
