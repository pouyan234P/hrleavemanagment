using AutoMapper;
using hrleavemanagement.application.features.leaveAllocation.request.Commands;
using hrleavemanagement.application.presistance.contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hrleavemanagement.application.features.leaveAllocation.handlers.Commands
{
    public class deleteLeaveAllocationCommandHandler : IRequestHandler<DeleteLeaveAllocationCommand>
    {
        private readonly IleaveAllocationRepository _ileaveAllocationRepository;

        public deleteLeaveAllocationCommandHandler(IleaveAllocationRepository ileaveAllocationRepository)
        {
            _ileaveAllocationRepository = ileaveAllocationRepository;
        }

        public async Task<Unit> Handle(DeleteLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            await _ileaveAllocationRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
