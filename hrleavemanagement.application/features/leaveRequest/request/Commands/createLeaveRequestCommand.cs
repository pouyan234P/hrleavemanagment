using hrleavemanagement.application.DTOs.LeaveRequest;
using hrleavemanagement.application.DTOs.LeaveType;
using hrleavemanagement.application.Responses;

//using hrleavemanagement.application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace hrleavemanagement.application.features.leaveRequest.request.Commands
{
    public class createLeaveRequestCommand : IRequest<baseCommandResponse>
    {
        public CreateLeaveRequestDto LeaveRequestDto { get; set; }

    }
}
