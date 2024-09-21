using FluentValidation;
using hrleavemanagement.application.presistance.contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hrleavemanagement.application.DTOs.LeaveRequest.Validators
{
    public class createLeaveRequestDtoValidator : AbstractValidator<CreateLeaveRequestDto>
    {
        private readonly IleaveRequestRepository _ileaveRequestRepository;

        public createLeaveRequestDtoValidator(IleaveRequestRepository ileaveRequestRepository)
        {
            _ileaveRequestRepository = ileaveRequestRepository;
            Include(new ILeaveRequestDtoValidator(_ileaveRequestRepository));
           
        }
    }
}
