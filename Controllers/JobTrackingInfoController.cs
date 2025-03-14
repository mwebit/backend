using Datacom.Models;
using Datacom.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Datacom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobTrackingInfoController : ControllerBase
    {
        IJobTrackingService _jobTrackingService;

        public JobTrackingInfoController(IJobTrackingService jobTrackingService)
        {
            _jobTrackingService = jobTrackingService;
        }
        
        [HttpGet]
        public IEnumerable<JobTrackingInfo> GetJobTrackingInfos()
        {
            return _jobTrackingService.GetJobTrackingInfos();
        }
        
        [HttpGet("{id}")]
        public JobTrackingInfo GetJobTrackingInfoById(int id)
        {
            return _jobTrackingService.GetJobTrackingInfoById(id);
        }
        
        [HttpPost]
        public JobTrackingInfo PostJobTrackingInfo(JobTrackingInfo jobTrackingInfo)
        {
            return _jobTrackingService.PostJobTrackingInfo(jobTrackingInfo);
        }
        
        [HttpPut]
        public JobTrackingInfo PutJobTrackingInfo(JobTrackingInfo jobTrackingInfo)
        {
            return _jobTrackingService.PutJobTrackingInfo(jobTrackingInfo);
        }
        
        [HttpDelete("{id}")]
        public void DeleteJobTrackingInfo(int id)
        {
            _jobTrackingService.DeleteJobTrackingInfo(id);
        }   

    }
}
