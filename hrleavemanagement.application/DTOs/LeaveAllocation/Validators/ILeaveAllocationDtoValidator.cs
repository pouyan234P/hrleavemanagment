using FluentValidation;
using hrleavemanagement.application.DTOs.LeaveAllocation;
using hrleavemanagement.application.presistance.contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.DTOs.LeaveAllocation.Validators
{
    public class ILeaveAllocationDtoValidator : AbstractValidator<ILeaveAllocationDto>
    {
        private readonly IleaveAllocationRepository _ileaveAllocationRepository;

        public ILeaveAllocationDtoValidator(IleaveAllocationRepository ileaveAllocationRepository)
        {
            _ileaveAllocationRepository = ileaveAllocationRepository;
            RuleFor(p => p.NumberOfDays)
                .GreaterThan(0).WithMessage("{PropertyName} must greater than {ComparisonValue}");

            RuleFor(p => p.Period)
                .GreaterThanOrEqualTo(DateTime.Now.Year).WithMessage("{PropertyName} must be after {ComparisonValue}");

            RuleFor(p => p.LeaveTypeId)
                .GreaterThan(0)
                .MustAsync(async (id, token) => 
                {
                    var leaveTypeExists = await _ileaveAllocationRepository.Exists(id);
                    return leaveTypeExists;
                })
                .WithMessage("{PropertyName} does not exist.");
            
        }
    }
}
