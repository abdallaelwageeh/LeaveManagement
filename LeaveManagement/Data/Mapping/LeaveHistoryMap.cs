using LeaveManagement.Data.Migrations.Entity;
using System.Data.Entity.ModelConfiguration;

namespace LeaveManagement.Data.Migrations.Mapping
{
    public class LeaveHistoryMap:EntityTypeConfiguration<LeaveHistory>
    {
        public LeaveHistoryMap()
        {
            ToTable("LeaveHistory");
            HasKey(x => x.LeaveHistoryId);
            Property(x => x.LeaveHistoryId).HasColumnName(@"Id").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetime").IsRequired();
            Property(x => x.EndDate).HasColumnName(@"EndDate").HasColumnType("datetime").IsRequired();
            Property(x => x.RequestingEmployeeId).HasColumnName(@"RequestingEmployeeId").HasMaxLength(4000).IsRequired();
            Property(x => x.Approved).HasColumnName(@"Approved").HasColumnType("bit").IsOptional();
            Property(x => x.ApprovedById).HasColumnName(@"ApprovedById").HasMaxLength(4000).IsRequired();
            Property(x => x.LeaveTypeId).HasColumnName(@"LeaveTypeId").HasColumnType("int").IsRequired();
            HasOptional(x => x.RequestingEmployee).WithMany().HasForeignKey(x => x.RequestingEmployeeId);
            HasOptional(x => x.LeaveType).WithMany().HasForeignKey(x => x.LeaveTypeId);
            HasOptional(x => x.ApprovedBy).WithMany().HasForeignKey(x => x.ApprovedById);
        }
    }
}
