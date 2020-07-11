using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Data.Migrations.Entity
{
    public class LeaveType
    {
        public int LeaveTypeId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
