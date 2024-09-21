using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands;
using hrleavemanagement.application.DTOs.LeaveAllocation.Validators;
using hrleavemanagement.application.Execeptions;
using hrleavemanagement.application.presistance.contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Handlers.Commands
{
    public class updateLeaveAllocationCommandHandler : IRequestHandler<updateLeaveAllocationCommand, Unit>
    {
        private readonly IleaveAllocationRepository _ileaveAllocationRepository;
        private readonly IMapper _mapper;

        public updateLeaveAllocationCommandHandler(IleaveAllocationRepository ileaveAllocationRepository,IMapper mapper)
        {
            _ileaveAllocationRepository = ileaveAllocationRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(updateLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateLeaveAllocationDtoValidator(_ileaveAllocationRepository);
            var validatorresult = await validator.ValidateAsync(request.LeaveAllocationDto);
            if (validatorresult.IsValid==false) 
            {
                throw new ValidationException(validatorresult);
            }
            var leavealloction = await _ileaveAllocationRepository.Get(request.LeaveAllocationDto.Id);
            _mapper.Map(request.LeaveAllocationDto, leavealloction);
            await _ileaveAllocationRepository.Update(leavealloction);
            return Unit.Value;
        }
    }
}
