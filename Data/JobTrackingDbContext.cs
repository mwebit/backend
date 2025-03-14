using Datacom.Models;
using Microsoft.EntityFrameworkCore;

namespace Datacom.Data
{
    public class JobTrackingDbContext : DbContext
    {

        public JobTrackingDbContext(DbContextOptions<JobTrackingDbContext> options) : base(options)
        {

        }

        public DbSet<JobTrackingInfo> JobTrackingInfos { get; set; }

    }
}
