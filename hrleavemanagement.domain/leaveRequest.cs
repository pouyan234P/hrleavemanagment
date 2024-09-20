using hrleavemanagement.domain.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrleavemanagement.domain
{
    public class leaveRequest:baseDomainEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int leaveTypeId { get; set; }
        public DateTime DateRequest { get; set; }
        public DateTime DateActioned { get; set; }
        public bool ? Approved { get; set; }
        public bool Cancelled { get; set; }
    }
}
