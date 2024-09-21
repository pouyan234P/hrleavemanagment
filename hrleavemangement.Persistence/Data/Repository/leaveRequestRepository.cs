using hrleavemanagement.application.presistance.contracts;
using hrleavemanagement.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrleavemangement.Persistence.Data.Repository
{
    public class leaveRequestRepository:genericRepository<leaveRequests>,IleaveRequestRepository
    {
        private readonly hrleaveManagementDb _db;

        public leaveRequestRepository(hrleaveManagementDb db):base(db) 
        {
            _db = db;
        }
    }
}
