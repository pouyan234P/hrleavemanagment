using hrleavemanagement.application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrleavemanagement.application.features.leaveTypes.request.Commands
{
    public class updateLeaveTypeCommand:IRequest<Unit>
    {
        public leaveTypeDto leaveTypeDto { get; set; }
    }
}
