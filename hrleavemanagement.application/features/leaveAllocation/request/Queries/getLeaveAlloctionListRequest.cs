using hrleavemanagement.application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrleavemanagement.application.features.leaveAllocation.request.Queries
{
    public class getLeaveAlloctionListRequest: IRequest<IEnumerable<leaveAllocationDto>>
    {
    }
}
