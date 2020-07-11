using LeaveManagement.Data.Migrations.Entity;
using System.Data.Entity.ModelConfiguration;

namespace LeaveManagement.Data.Migrations.Mapping
{
    public class LeaveAllocationMap:EntityTypeConfiguration<LeaveAllocation>
    {
        public LeaveAllocationMap()
        {

            ToTable("LeaveAllocation");
            HasKey(x => x.LeaveAllocationId);

            Property(x => x.LeaveAllocationId).HasColumnName(@"Id").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NumberOfDays).HasColumnName(@"NumberOfDays").HasColumnType("int").IsRequired();
            Property(x => x.EmpoyeeId).HasColumnName(@"EmpoyeeId").HasColumnType("int").IsRequired();
            Property(x => x.LeaveTypeId).HasColumnName(@"LeaveTypeId").HasColumnType("int").IsRequired();
            Property(x => x.DateCreated).HasColumnName(@"DateCreated").HasColumnType("datetime").IsRequired();
            HasOptional(x => x.Employee).WithMany().HasForeignKey(x => x.EmpoyeeId);
            HasOptional(x => x.LeaveType).WithMany().HasForeignKey(x => x.LeaveTypeId);
        }
    }
}
