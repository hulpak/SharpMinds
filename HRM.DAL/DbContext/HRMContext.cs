using HRM.DAL.DomainValue;
using HRM.DAL.EF;
using HRM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HRM.DAL.DbContext
{
    public class HRMContext:System.Data.Entity.DbContext
    {
        public HRMContext() : base(string.Format("HRMContext", DbConnection.HRMContext)) { }

        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<StatusType> StatusTypes { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<RequestType> RequestType { get; set; }
        public virtual DbSet<OfficialHollidays> OfficialHollidayses { get; set; }
        public virtual DbSet<UserLevel> UserLevels { get; set; }
        public virtual DbSet<UserDocument> UserDocuments { get; set; }
        public virtual DbSet<UserTeam> UserTeams { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<UserRequest> Requests { get; set; }
        public virtual DbSet<User> Users { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
             modelBuilder.Configurations.Add(new TeamMap());
             modelBuilder.Configurations.Add(new RoleMap());
             modelBuilder.Configurations.Add(new StatusTypeMap());
             modelBuilder.Configurations.Add(new SettingsMap());
             modelBuilder.Configurations.Add(new StatusMap());
             modelBuilder.Configurations.Add(new RequestTypeMap());
             modelBuilder.Configurations.Add(new OfficialHollidaysMap());
             modelBuilder.Configurations.Add(new UserLevelMap());
             modelBuilder.Configurations.Add(new UserDocumentMap());
             modelBuilder.Configurations.Add(new UserTeamMap());
             modelBuilder.Configurations.Add(new UserRoleMap());
             modelBuilder.Configurations.Add(new UserRequestMap());
             modelBuilder.Configurations.Add(new UserMap());

            modelBuilder.Entity<User>().
      HasMany(c => c.Teams).
      WithMany(p => p.Users).
      Map(
       m =>
       {
           m.ToTable("UserTeam");
           m.MapLeftKey("UserId");
           m.MapRightKey("TeamId");
          
       });
           

            //many to many
              modelBuilder.Entity<User>()
             .HasMany<Role>(t => t.Roles)
             .WithMany(u => u.Users)
             .Map(tu =>
             {
                 tu.ToTable("UserRole");
                 tu.MapLeftKey("UserId");
                 tu.MapRightKey("RoleId");
                 
             });
            
    
        }
    }
}
