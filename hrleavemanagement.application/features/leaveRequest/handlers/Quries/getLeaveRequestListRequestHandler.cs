using AutoMapper;
using hrleavemanagement.application.DTOs;
using hrleavemanagement.application.features.leaveRequest.request.Queris;
using hrleavemanagement.application.presistance.contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrleavemanagement.application.features.leaveRequest.handlers.Quries
{
    public class getLeaveRequestListRequestHandler : IRequestHandler<getLeaveRequestListRequest, IEnumerable<leaveRequestDto>>
    {
        private readonly IleaveRequestRepository _ileaveRequest;
        private readonly IMapper _mapper;

        public getLeaveRequestListRequestHandler(IleaveRequestRepository ileaveRequest,IMapper mapper)
        {
            _ileaveRequest = ileaveRequest;
            _mapper = mapper;
        }
        public async Task<IEnumerable<leaveRequestDto>> Handle(getLeaveRequestListRequest request, CancellationToken cancellationToken)
        {
            var leaverequest=await _ileaveRequest.GetAll();
            return _mapper.Map<IEnumerable<leaveRequestDto>>(leaverequest);
        }
    }
}
