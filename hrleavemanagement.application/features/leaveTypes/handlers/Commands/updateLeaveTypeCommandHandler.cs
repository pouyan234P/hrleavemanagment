using AutoMapper;
using hrleavemanagement.application.DTOs.LeaveType.Validators;
using hrleavemanagement.application.Execeptions;
using hrleavemanagement.application.features.leaveTypes.request.Commands;
using hrleavemanagement.application.presistance.contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrleavemanagement.application.features.leaveTypes.handlers.Commands
{
    public class updateLeaveTypeCommandHandler : IRequestHandler<updateLeaveTypeCommand, Unit>
    {
        private readonly IleaveTypeRepository _ileaveTypeRepository;
        private readonly IMapper _mapper;

        public updateLeaveTypeCommandHandler(IleaveTypeRepository ileaveTypeRepository,IMapper mapper)
        {
            _ileaveTypeRepository = ileaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(updateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var validator=new updateLeaveTypeDtoValidator();
            var validatorresult = await validator.ValidateAsync(request.leaveTypeDto);
            if (validatorresult.IsValid == false)
                throw new ValidationException(validatorresult);
            var leavetype=await _ileaveTypeRepository.Get(request.leaveTypeDto.Id);
            _mapper.Map(request.leaveTypeDto, leavetype);
            await _ileaveTypeRepository.Update(leavetype);
            return Unit.Value;
        }
    }
}
