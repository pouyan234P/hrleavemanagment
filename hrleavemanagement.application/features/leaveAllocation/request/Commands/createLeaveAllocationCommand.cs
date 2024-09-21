
using hrleavemanagement.application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace hrleavemanagement.application.features.leaveAllocation.request.Commands
{
    public class createLeaveAllocationCommand : IRequest<int>
    {
        public leaveAllocationDto LeaveAllocationDto { get; set; }
    }
}
