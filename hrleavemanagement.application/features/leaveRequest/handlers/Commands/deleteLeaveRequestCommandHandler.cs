using AutoMapper;
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
    public class deleteLeaveRequestCommandHandler : IRequestHandler<deleteLeaveRequestCommand>
    {
        private readonly IleaveRequestRepository _ileaveRequestRepository;

        public deleteLeaveRequestCommandHandler(IleaveRequestRepository ileaveRequestRepository)
        {
           _ileaveRequestRepository = ileaveRequestRepository;
        }

        public async Task<Unit> Handle(deleteLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            await _ileaveRequestRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
