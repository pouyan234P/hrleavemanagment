using AutoMapper;
using HR.LeaveManagement.Application.DTOs.LeaveRequest.Validators;
using hrleavemanagement.application.Execeptions;
using hrleavemanagement.application.features.leaveRequest.request.Commands;
using hrleavemanagement.application.presistance.contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hrleavemanagement.application.features.leaveRequest.handlers.Commands
{
    public class UpdateLeaveRequestCommandHandler : IRequestHandler<updateLeaveRequestCommand, Unit>
    {
        private readonly IleaveRequestRepository _ileaveRequestRepository;
        private readonly IMapper _mapper;

        public UpdateLeaveRequestCommandHandler(IleaveRequestRepository ileaveRequestRepository,IMapper mapper)
        {
            _ileaveRequestRepository = ileaveRequestRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(updateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var valdiator = new updateLeaveRequestDtoValidator(_ileaveRequestRepository);
            var valdiatorresult =await  valdiator.ValidateAsync(request.LeaveRequestDto);
            if(valdiatorresult.IsValid==false)
            {
                throw new ValidationException(valdiatorresult);
            }
            if(request.LeaveRequestDto!=null)
            {
                var leaverequest = await _ileaveRequestRepository.Get(request.LeaveRequestDto.Id);
                _mapper.Map(request.LeaveRequestDto, leaverequest);
                await _ileaveRequestRepository.Update(leaverequest);
            }
            else if(request.changeLeaveRequestApprovalDto!=null)
            {
               
            }
            
            return Unit.Value;
        }
    }
}
