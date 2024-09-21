
using hrleavemanagement.application.DTOs.LeaveRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace hrleavemanagement.application.features.leaveRequest.request.Commands
{
    public class updateLeaveRequestCommand : IRequest<Unit>
    {
        public UpdateLeaveRequestDto LeaveRequestDto { get; set; }
        public ChangeLeaveRequestApprovalDto changeLeaveRequestApprovalDto { get; set; }

    }
}
