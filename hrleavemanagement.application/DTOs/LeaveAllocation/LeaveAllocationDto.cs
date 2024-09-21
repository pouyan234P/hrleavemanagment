using hrleavemanagement.application.DTOs.Common;
using hrleavemanagement.application.DTOs.LeaveType;
using System;
using System.Collections.Generic;
using System.Text;

namespace hrleavemanagement.application.DTOs.LeaveAllocation
{
    public class LeaveAllocationDto : BaseDto, ILeaveAllocationDto
    {
        public int NumberOfDays { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public string EmployeeId { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
