using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using HRM.DAL.Models;

namespace HRM.DAL.EF
{
    public class SettingsMap : EntityTypeConfiguration<Settings>
    {
        public SettingsMap()
        {
            ToTable("Settings", "hrm").HasKey(t => t.Id);
            Property(t => t.SickDays).IsRequired();
            Property(t => t.VacationDays).IsRequired();
        }

    }
}
