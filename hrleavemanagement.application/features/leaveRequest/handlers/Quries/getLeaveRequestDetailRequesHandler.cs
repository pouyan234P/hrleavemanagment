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
    public class getLeaveRequestDetailRequesHandler : IRequestHandler<getLeaveRequestDetailRequest, leaveRequestDto>
    {
        private readonly IleaveRequestRepository _ileaveRequestRepository;
        private readonly IMapper _mapper;

        public getLeaveRequestDetailRequesHandler(IleaveRequestRepository ileaveRequestRepository,IMapper mapper)
        {
            _ileaveRequestRepository = ileaveRequestRepository;
            _mapper = mapper;
        }
        public async Task<leaveRequestDto> Handle(getLeaveRequestDetailRequest request, CancellationToken cancellationToken)
        {
            var myleaverequest = await _ileaveRequestRepository.Get(request.id);
            return _mapper.Map<leaveRequestDto>(myleaverequest);
        }
    }
}
