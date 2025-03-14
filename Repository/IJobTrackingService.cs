using Datacom.Models;

namespace Datacom.Repository
{
    public interface IJobTrackingService
    {
        public IEnumerable<JobTrackingInfo> GetJobTrackingInfos();

        public JobTrackingInfo GetJobTrackingInfoById(int id);

        public JobTrackingInfo PostJobTrackingInfo(JobTrackingInfo jobTrackingInfo);

        public JobTrackingInfo PutJobTrackingInfo(JobTrackingInfo jobTrackingInfo);

        public void DeleteJobTrackingInfo(int id);

    }
}
