using LeaveManagement.Data.Migrations.Entity;
using System.Data.Entity.ModelConfiguration;

namespace LeaveManagement.Data.Migrations.Mapping
{
    public class LeaveTypeMap: EntityTypeConfiguration<LeaveType>
    {
        public LeaveTypeMap()
        {
            ToTable("LeaveType");
            HasKey(x => x.LeaveTypeId);
            Property(x => x.LeaveTypeId).HasColumnName(@"Id").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasMaxLength(200).IsOptional();
            Property(x => x.DateCreated).HasColumnName(@"DateCreated").HasColumnType("datetime").IsOptional();
        }
    }
}
