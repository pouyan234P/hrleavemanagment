using hrleavemanagement.application.presistance.contracts;
using hrleavemanagement.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrleavemangement.Persistence.Data.Repository
{
    public class leaveAllocationRepository:genericRepository<leaveAllocations>,IleaveAllocationRepository
    {
        private readonly hrleaveManagementDb _db;

        public leaveAllocationRepository(hrleaveManagementDb db):base(db)
        {
            _db = db;
        }
    }
}
