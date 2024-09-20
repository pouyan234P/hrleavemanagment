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
    public class getLeaveTypeListRequestHandler : IRequestHandler<getLeaveTypeListRequest, IEnumerable<leaveTypeDto>>
    {
        private readonly IleaveTypeRepository _ileaveTypeRepository;
        private readonly IMapper _mapper;

        public getLeaveTypeListRequestHandler(IleaveTypeRepository ileaveTypeRepository,IMapper mapper)
        {
            _ileaveTypeRepository = ileaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<leaveTypeDto>> Handle(getLeaveTypeListRequest request, CancellationToken cancellationToken)
        {
            var leavetype=await _ileaveTypeRepository.GetAll();
            return _mapper.Map<IEnumerable<leaveTypeDto>>(leavetype);
        }
    }
}
