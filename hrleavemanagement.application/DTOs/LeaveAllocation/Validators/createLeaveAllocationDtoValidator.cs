using FluentValidation;
using HR.LeaveManagement.Application.DTOs.LeaveAllocation.Validators;
using hrleavemanagement.application.presistance.contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hrleavemanagement.application.DTOs.LeaveAllocation.Validators
{
    public class createLeaveAllocationDtoValidator : AbstractValidator<CreateLeaveAllocationDto>
    {
        private readonly IleaveAllocationRepository _ileaveAllocationRepository;

        public createLeaveAllocationDtoValidator(IleaveAllocationRepository ileaveAllocationRepository)
        {
            _ileaveAllocationRepository = ileaveAllocationRepository;
            Include(new ILeaveAllocationDtoValidator(_ileaveAllocationRepository));
        }
    }
}
