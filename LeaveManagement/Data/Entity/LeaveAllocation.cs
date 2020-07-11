using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Data.Migrations.Entity
{
    public class LeaveAllocation
    {
        public int LeaveAllocationId { get; set; }
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        public Employee Employee { get; set; }
        public string EmpoyeeId { get; set; }
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
    }
}
