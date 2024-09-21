using hrleavemanagement.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrleavemanagement.application.presistance.contracts
{
    public interface IleaveAllocationRepository:IGenericRepository<leaveAllocations>
    {
    }
}
