using hrleavemanagement.application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace hrleavemanagement.application.DTOs.LeaveType
{
    public class CreateLeaveTypeDto : ILeaveTypeDto
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
