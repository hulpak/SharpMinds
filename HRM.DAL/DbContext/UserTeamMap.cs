using HRM.DAL.Models;
using System.Data.Entity.ModelConfiguration;

namespace HRM.DAL.EF
{
    public class UserTeamMap : EntityTypeConfiguration<UserTeam>
    {
        public UserTeamMap()
        {
            this.ToTable("UserTeam","hrm");
            this.HasKey(t => t.TeamId);
            this.HasKey(t => t.UserId);

        }
  
    }
}
