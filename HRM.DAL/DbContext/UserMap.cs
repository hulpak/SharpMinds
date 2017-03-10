using HRM.DAL.Models;
using System.Data.Entity.ModelConfiguration;
namespace HRM.DAL.EF
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        

        public UserMap()
        {
            ToTable("User", "hrm").HasKey(t => t.Id);
           
            Property(t => t.FullName).HasMaxLength(128).IsRequired();
            Property(t => t.StartDate).IsRequired();
            Property(t => t.Password).HasMaxLength(128).IsRequired();
            Property(t => t.Email).HasMaxLength(128).IsRequired();
            Property(t => t.StatusId).IsRequired();
            Property(t => t.LevelId).IsRequired();
            Property(t => t.UserRole).IsRequired();
            Property(t => t.UserTeam).IsRequired();

            HasMany(t => t.Roles).WithMany(c => c.Users)
                                .Map(t => t.ToTable("UserRole")
                                    .MapLeftKey("UserId")
                                    .MapRightKey("RoleId"));

            HasMany(t => t.Teams).WithMany(c => c.Users)
                               .Map(t => t.ToTable("UserTeam")
                                   .MapLeftKey("UserId")
                                   .MapRightKey("TeamId"));


            HasRequired(t => t.Status).WithMany(c => c.Users).HasForeignKey(t => t.StatusId).WillCascadeOnDelete(false);
            HasRequired(t => t.UserLevel).WithMany(c => c.Users).HasForeignKey(t => t.LevelId).WillCascadeOnDelete(false);
            
                           
        }
     
    }
}
