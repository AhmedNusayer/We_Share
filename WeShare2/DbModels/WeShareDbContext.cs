using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeShare2.DbModels
{
    public class WeShareDbContext: DbContext
    {
        public WeShareDbContext(DbContextOptions<WeShareDbContext>options)
            : base(options)
        {

        }

        public DbSet<TripRequest> TripRequests { get; set; }
        public DbSet<TripPlan> TripPlans { get; set; }
    }
}
