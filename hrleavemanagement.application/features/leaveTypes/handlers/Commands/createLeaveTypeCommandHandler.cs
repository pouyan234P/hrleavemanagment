using AutoMapper;
using hrleavemanagement.application.DTOs.LeaveType.Validators;
using hrleavemanagement.application.Execeptions;
using hrleavemanagement.application.features.leaveTypes.request.Commands;
using hrleavemanagement.application.presistance.contracts;
using hrleavemanagement.domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrleavemanagement.application.features.leaveTypes.handlers.Commands
{
    public class createLeaveTypeCommandHandler : IRequestHandler<createLeaveTypeCommand, int>
    {
        private readonly IleaveTypeRepository _ileaveTypeRepository;
        private readonly IMapper _mapper;

        public createLeaveTypeCommandHandler(IleaveTypeRepository ileaveTypeRepository,IMapper mapper)
        {
            _ileaveTypeRepository = ileaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(createLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new IcreateLeaveTypeDtoValidator();
            var validatorResult = await validator.ValidateAsync(request.leaveTypeDto);
            if (validatorResult.IsValid==false) 
            {
                throw new ValidationException(validatorResult);
            }
            var leavetype=_mapper.Map<leaveType>(request.leaveTypeDto);
           var myleavetypes = await _ileaveTypeRepository.Add(leavetype);
            return myleavetypes.Id;
        }
    }
}
