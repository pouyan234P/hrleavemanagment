using hrleavemanagement.application.DTOs;
using hrleavemanagement.application.DTOs.LeaveType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrleavemanagement.application.features.leaveTypes.request.Commands
{
    public class createLeaveTypeCommand:IRequest<int>
    {
        public CreateLeaveTypeDto leaveTypeDto { get; set; }
    }
}
