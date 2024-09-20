using hrleavemanagement.application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrleavemanagement.application.features.leaveRequest.request.Queris
{
    public class getLeaveRequestDetailRequest: IRequest<leaveRequestDto>
    {
        public int id { get; set; }
    }
}
