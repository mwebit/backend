using Datacom.Models;
using Datacom.Data;

namespace Datacom.Repository
{
    public class JobTrackingService : IJobTrackingService
    {
        JobTrackingDbContext _context;

        public JobTrackingService(JobTrackingDbContext context)
        {
            _context = context;
        }

        public void DeleteJobTrackingInfo(int id)
        {
            var jobTrackingInfo = _context.JobTrackingInfos.FirstOrDefault(x => x.Id == id);
            if (jobTrackingInfo != null)
            {
                _context.JobTrackingInfos.Remove(jobTrackingInfo);
                _context.SaveChanges();
            }
        }

        public JobTrackingInfo GetJobTrackingInfoById(int id)
        {
            return _context.JobTrackingInfos.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<JobTrackingInfo> GetJobTrackingInfos()
        {
            return _context.JobTrackingInfos.ToList();
        }

        public JobTrackingInfo PostJobTrackingInfo(JobTrackingInfo jobTrackingInfo)
        {
            _context.JobTrackingInfos.Add(jobTrackingInfo);
            _context.SaveChangesAsync();
            return jobTrackingInfo;
        }

        public JobTrackingInfo PutJobTrackingInfo(JobTrackingInfo jobTrackingInfo)
        {
            var existingJobTrackingInfo = _context.JobTrackingInfos.FirstOrDefault(x => x.Id == jobTrackingInfo.Id);
            if (existingJobTrackingInfo != null)
            {
                _context.Entry(existingJobTrackingInfo).CurrentValues.SetValues(jobTrackingInfo);
                _context.SaveChanges();
            }
            return jobTrackingInfo;
        }
    }
}
