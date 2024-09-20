using AutoMapper;
using hrleavemanagement.application.DTOs;
using hrleavemanagement.application.features.leaveTypes.request.Queries;
using hrleavemanagement.application.presistance.contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrleavemanagement.application.features.leaveTypes.handlers.Queres
{
    public class getLeaveTypeDetailRequestHandler : IRequestHandler<getLeaveTypeDeatailRequest, leaveTypeDto>
    {
        private readonly IleaveTypeRepository _ileaveTypeRepository;
        private readonly IMapper _mapper;

        public getLeaveTypeDetailRequestHandler(IleaveTypeRepository ileaveTypeRepository,IMapper mapper)
        {
            _ileaveTypeRepository = ileaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<leaveTypeDto> Handle(getLeaveTypeDeatailRequest request, CancellationToken cancellationToken)
        {
            var leavetype = await _ileaveTypeRepository.Get(request.id);
            return _mapper.Map<leaveTypeDto>(leavetype);
        }
    }
}
