using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrleavemanagement.domain.Comman
{
    public abstract class baseDomainEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string createdBy { get; set; }
        public DateTime lastModifiedDate { get; set; }
        public string lastModifiedBy { get; set; }
    }
}
