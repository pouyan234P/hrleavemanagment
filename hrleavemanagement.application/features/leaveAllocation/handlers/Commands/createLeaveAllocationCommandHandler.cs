using AutoMapper;

using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using hrleavemanagement.application.features.leaveAllocation.request.Commands;
using hrleavemanagement.application.presistance.contracts;
using hrleavemanagement.domain;
using HR.LeaveManagement.Application.DTOs.LeaveAllocation.Validators;
using hrleavemanagement.application.DTOs.LeaveAllocation.Validators;
using hrleavemanagement.application.Execeptions;

namespace hrleavemanagement.application.features.leaveAllocation.handlers.Commands
{
    public class createLeaveAllocationCommandHandler : IRequestHandler<createLeaveAllocationCommand, int>
    {
        private readonly IleaveAllocationRepository _ileaveAllocationRepository;
        private readonly IMapper _mapper;

        public createLeaveAllocationCommandHandler(IleaveAllocationRepository ileaveAllocationRepository,IMapper mapper)
        {
            _ileaveAllocationRepository = ileaveAllocationRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(createLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var validator = new ILeaveAllocationDtoValidator(_ileaveAllocationRepository);
            var validatorresult = await validator.ValidateAsync(request.LeaveAllocationDto);
            if(validatorresult.IsValid==false)
            {
                throw new ValidationException(validatorresult);
            }
            var leaveallocation=_mapper.Map<leaveAllocations>(request.LeaveAllocationDto);
            var myleavealloction=await _ileaveAllocationRepository.Add(leaveallocation);
            return myleavealloction.Id;
        }
    }
}
