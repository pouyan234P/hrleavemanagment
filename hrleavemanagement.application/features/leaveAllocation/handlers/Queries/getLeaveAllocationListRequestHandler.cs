using AutoMapper;
using hrleavemanagement.application.DTOs;
using hrleavemanagement.application.features.leaveAllocation.request.Queries;
using hrleavemanagement.application.presistance.contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrleavemanagement.application.features.leaveAllocation.handlers.Queries
{
    public class getLeaveAllocationListRequestHandler : IRequestHandler<getLeaveAlloctionListRequest, IEnumerable<leaveAllocationDto>>
    {
        private readonly IleaveAllocationRepository _ileaveAllocationRepository;
        private readonly IMapper _mapper;

        public getLeaveAllocationListRequestHandler(IleaveAllocationRepository ileaveAllocationRepository,IMapper mapper)
        {
            _ileaveAllocationRepository = ileaveAllocationRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<leaveAllocationDto>> Handle(getLeaveAlloctionListRequest request, CancellationToken cancellationToken)
        {
            var leaveallocation = await _ileaveAllocationRepository.GetAll();
            return _mapper.Map<IEnumerable<leaveAllocationDto>>(leaveallocation);
        }
    }
}
