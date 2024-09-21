using FluentValidation;
using hrleavemanagement.application.DTOs.LeaveRequest;
using hrleavemanagement.application.presistance.contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hrleavemanagement.application.DTOs.LeaveRequest.Validators
{
    public class ILeaveRequestDtoValidator : AbstractValidator<ILeaveRequestDto>
    {
        private readonly IleaveRequestRepository _ileaveRequestRepository;

        public ILeaveRequestDtoValidator(IleaveRequestRepository ileaveRequestRepository)
        {
            _ileaveRequestRepository = ileaveRequestRepository;
            RuleFor(p => p.StartDate)
                .LessThan(p => p.EndDate).WithMessage("{PropertyName} must be before {ComparisonValue");
            RuleFor(p => p.EndDate)
                  .GreaterThan(p => p.StartDate).WithMessage("{PropertyName} must be after {ComparisonValue}");

            RuleFor(p => p.LeaveTypeId)
                .GreaterThan(0)
                .MustAsync(async (id, token) =>
                {
                    var leavetypeExist = await _ileaveRequestRepository.Exists(id);
                    return !leavetypeExist;
                }).WithMessage("{PropertyName} does not exist");
            
        }
    }
}
