using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace hrleavemanagement.application.features.leaveTypes.request.Commands
{
    public class deleteLeaveTypeCommand : IRequest
    {
        public int Id { get; set; }
    }
}
