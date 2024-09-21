using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace hrleavemanagement.application.features.leaveAllocation.request.Commands
{
    public class DeleteLeaveAllocationCommand : IRequest
    {
        public int Id { get; set; }
    }
}
