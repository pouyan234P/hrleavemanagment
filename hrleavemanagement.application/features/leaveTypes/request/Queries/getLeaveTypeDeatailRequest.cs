using hrleavemanagement.application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrleavemanagement.application.features.leaveTypes.request.Queries
{
    public class getLeaveTypeDeatailRequest : IRequest<leaveTypeDto>
    {
        public int id { get; set; }
    }
}
