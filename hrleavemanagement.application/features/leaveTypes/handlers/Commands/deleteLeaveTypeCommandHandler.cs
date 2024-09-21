using AutoMapper;
using hrleavemanagement.application.features.leaveTypes.request.Commands;
using hrleavemanagement.application.presistance.contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hrleavemanagement.application.features.leaveTypes.handlers.Commands
{
    public class deleteLeaveTypeCommandHandler : IRequestHandler<deleteLeaveTypeCommand>
    {
        private readonly IleaveTypeRepository _ileaveTypeRepository;
        private readonly IMapper _mapper;

        public deleteLeaveTypeCommandHandler(IleaveTypeRepository ileaveTypeRepository,IMapper mapper)
        {
            _ileaveTypeRepository = ileaveTypeRepository;
            _mapper = mapper;
        }

     

        public async Task<Unit> Handle(deleteLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            await _ileaveTypeRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
