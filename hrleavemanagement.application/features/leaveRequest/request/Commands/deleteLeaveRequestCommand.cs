using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace hrleavemanagement.application.features.leaveRequest.request.Commands
{
    public class deleteLeaveRequestCommand : IRequest
    {
        public int Id { get; set; }
    }
}
