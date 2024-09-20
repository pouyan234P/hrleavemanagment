using AutoMapper;
using hrleavemanagement.application.DTOs;
using hrleavemanagement.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrleavemanagement.application.Helper
{
    public class autoMapper:Profile
    {
        public autoMapper()
        {
            CreateMap<leaveRequest, leaveRequestDto>().ReverseMap();
            CreateMap<leaveAllocation, leaveAllocationDto>().ReverseMap();
            CreateMap<leaveType, leaveTypeDto>().ReverseMap();
        }
    }
}
