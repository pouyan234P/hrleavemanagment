using hrleavemanagement.application.presistance.contracts;
using hrleavemangement.Persistence.Data;
using hrleavemangement.Persistence.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrleavemangement.Persistence
{
    public static class persistenceServicesRegistration
    {
        public static IServiceCollection configurePersistenceServices(this IServiceCollection services,IConfiguration configuration) 
        {
            services.AddDbContext<hrleaveManagementDb>(options => options.UseSqlServer(configuration.GetConnectionString("myconn")));
            services.AddScoped(typeof(IGenericRepository<>),typeof(genericRepository<>) );
            services.AddScoped<IleaveRequestRepository, leaveRequestRepository>();
            services.AddScoped<IleaveAllocationRepository, leaveAllocationRepository>();
            return services;
        }
    }
}
