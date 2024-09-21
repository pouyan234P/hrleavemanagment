using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrleavemanagement.application.DTOs.LeaveType.Validators
{
    public class updateLeaveTypeDtoValidator:AbstractValidator<leaveTypeDto>
    {
        public updateLeaveTypeDtoValidator()
        {
            Include(new IcreateLeaveTypeDtoValidator());

            RuleFor(p=>p.Id).NotNull().NotEmpty().WithMessage("{PropertyName} must be present");
        }
    }
}
