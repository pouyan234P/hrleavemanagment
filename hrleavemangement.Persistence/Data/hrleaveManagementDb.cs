using hrleavemanagement.domain;
using hrleavemanagement.domain.Comman;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrleavemangement.Persistence.Data
{
    public class hrleaveManagementDb:DbContext
    {
        public hrleaveManagementDb(DbContextOptions<hrleaveManagementDb> options): base(options) 
        {
            
        }
        public DbSet<leaveRequests> leaveRequests { get; set; }
        public DbSet<leaveType> leaveTypes { get; set; }
        public DbSet<leaveAllocations> leaveAllocations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(hrleaveManagementDb).Assembly);
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<baseDomainEntity>())
            {
                entry.Entity.lastModifiedDate = DateTime.Now;
                if(entry.State==EntityState.Added)
                {
                    entry.Entity.DateCreated = DateTime.Now;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
