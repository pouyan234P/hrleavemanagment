using hrleavemanagement.application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrleavemanagement.application.DTOs
{
    public class leaveTypeDto:baseDto
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
