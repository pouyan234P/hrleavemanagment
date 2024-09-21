using hrleavemanagement.application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;
using hrleavemanagement.application.DTOs.LeaveType;

namespace hrleavemanagement.application.DTOs.LeaveRequest
{
    public class LeaveRequestListDto : BaseDto
    {
        public string RequestingEmployeeId { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool? Approved { get; set; }
    }
}
