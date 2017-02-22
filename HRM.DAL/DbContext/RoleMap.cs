
using HRM.DAL.Models;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.EF
{

    public class RoleMap : EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            ToTable("Role", "hrm").HasKey(t => t.Id);
            Property(t => t.Name).HasMaxLength(128);

            
        }
    }
}
