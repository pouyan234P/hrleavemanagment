using hrleavemanagement.application.DTOs.Common;
using hrleavemanagement.application.DTOs.LeaveType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrleavemanagement.application.DTOs
{
    public class leaveTypeDto:BaseDto,ILeaveTypeDto
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
