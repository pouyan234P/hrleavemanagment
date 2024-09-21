using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using hrleavemanagement.application.presistance.contracts;
using hrleavemanagement.domain;
using hrleavemanagement.application.features.leaveRequest.request.Commands;
using hrleavemanagement.application.DTOs.LeaveRequest.Validators;
using hrleavemanagement.application.Execeptions;
using hrleavemanagement.application.Responses;

namespace hrleavemanagement.application.features.leaveRequest.handlers.Commands
{
    public class CreateLeaveRequestCommandHandler : IRequestHandler<createLeaveRequestCommand, baseCommandResponse>
    {
        private readonly IleaveRequestRepository _ileaveRequestRepository;
        private readonly IMapper _mapper;

        public CreateLeaveRequestCommandHandler(IleaveRequestRepository ileaveRequestRepository,IMapper mapper)
        {
            _ileaveRequestRepository = ileaveRequestRepository;
            _mapper = mapper;
        }
        public async Task<baseCommandResponse> Handle(createLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var response = new baseCommandResponse();
            var validator=new ILeaveRequestDtoValidator(_ileaveRequestRepository);
            var validatorresult = await validator.ValidateAsync(request.LeaveRequestDto);
            if (validatorresult.IsValid==false)
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors=validatorresult.Errors.Select(e => e.ErrorMessage).ToList();
                throw new ValidationException(validatorresult);
            }
            var leaverequest=_mapper.Map<leaveRequests>(request.LeaveRequestDto);
            var myleaverequest=await _ileaveRequestRepository.Add(leaverequest);

            response.Success=true;
            response.Message = "Creation Successful";
            response.id=leaverequest.Id;
            return response;
        }
    }
}
