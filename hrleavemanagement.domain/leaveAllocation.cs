using hrleavemanagement.domain.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrleavemanagement.domain
{
    public class leaveAllocation:baseDomainEntity
    {
        public int NumberOfDays { get; set; }
        public int LeaveTypeId { get; set; }
        public int period { get; set; }
    }
}
