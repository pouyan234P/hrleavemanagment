using hrleavemanagement.application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace hrleavemanagement.application.DTOs.LeaveAllocation
{
    public class UpdateLeaveAllocationDto : BaseDto,ILeaveAllocationDto
    {
        public int NumberOfDays { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
