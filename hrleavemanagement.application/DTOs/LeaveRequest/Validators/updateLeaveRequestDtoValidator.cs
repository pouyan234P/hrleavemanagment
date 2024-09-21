using FluentValidation;
using hrleavemanagement.application.DTOs.LeaveRequest;
using hrleavemanagement.application.DTOs.LeaveRequest.Validators;
using hrleavemanagement.application.presistance.contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.DTOs.LeaveRequest.Validators
{
    public class updateLeaveRequestDtoValidator : AbstractValidator<UpdateLeaveRequestDto>
    {
        private readonly IleaveRequestRepository _ileaveRequestRepository;

        public updateLeaveRequestDtoValidator(IleaveRequestRepository ileaveRequestRepository)
        {
            _ileaveRequestRepository = ileaveRequestRepository;
            Include(new ILeaveRequestDtoValidator(_ileaveRequestRepository));

            RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} must be present");
           
        }
    }
}
