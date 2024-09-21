using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrleavemanagement.application.DTOs.LeaveType.Validators
{
    public class IcreateLeaveTypeDtoValidator:AbstractValidator<ILeaveTypeDto>
    {
        public IcreateLeaveTypeDtoValidator()
        {
            RuleFor(p=>p.Name).NotEmpty().WithMessage("{PropertyName} is required").NotNull().MaximumLength(50).WithMessage("{PropertyName} must no exceed 50 characters.");
            RuleFor(p => p.DefaultDays)
                .NotEmpty().WithMessage("{propertyName} is required")
                .GreaterThan(0).WithMessage("{PropertyName} must be at leat 1")
                .LessThan(100).WithMessage("{PropertyName} must be less than 100");
        }
    }
}
