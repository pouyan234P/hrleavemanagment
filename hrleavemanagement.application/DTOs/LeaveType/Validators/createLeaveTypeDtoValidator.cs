using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrleavemanagement.application.DTOs.LeaveType.Validators
{
    public class createLeaveTypeDtoValidator:AbstractValidator<CreateLeaveTypeDto>
    {
        public createLeaveTypeDtoValidator()
        {
            Include(new IcreateLeaveTypeDtoValidator());
        }
    }
}
