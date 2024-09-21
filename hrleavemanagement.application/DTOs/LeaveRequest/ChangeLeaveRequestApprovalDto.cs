using hrleavemanagement.application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace hrleavemanagement.application.DTOs.LeaveRequest
{
    public class ChangeLeaveRequestApprovalDto : BaseDto
    {
        public bool Approved { get; set; }
    }
}
