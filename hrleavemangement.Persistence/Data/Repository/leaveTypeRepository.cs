using hrleavemanagement.application.presistance.contracts;
using hrleavemanagement.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrleavemangement.Persistence.Data.Repository
{
    public class leaveTypeRepository:genericRepository<leaveType>,IleaveTypeRepository
    {
        private readonly hrleaveManagementDb _db;

        public leaveTypeRepository(hrleaveManagementDb db):base(db)
        {
            _db = db;
        }
    }
}
