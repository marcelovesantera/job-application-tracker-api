using JobApplicationTrackerApi.Domain;
using JobApplicationTrackerApi.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JobApplicationTrackerApi.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobApplicationController : ControllerBase
    {
        private readonly IJobApplicationRepository _jobApplicationRepository;

        public JobApplicationController(IJobApplicationRepository jobApplicationRepository)
        {
            _jobApplicationRepository = jobApplicationRepository;
        }

        [HttpGet]
        public IActionResult GetAllJobApplications()
        {
            var jobApplications = _jobApplicationRepository.GetAllJobApplications();
            return Ok(jobApplications);
        }

        [HttpGet("{id}")]
        public IActionResult GetJobApplicationById(int id)
        {
            var jobApplication = _jobApplicationRepository.GetJobApplicationById(id);

            if (jobApplication == null)
            {
                return NotFound();
            }

            return Ok(jobApplication);
        }

        [HttpPost]
        public IActionResult AddJobApplication([FromBody] JobApplication jobApplication)
        {
            _jobApplicationRepository.AddJobApplication(jobApplication);
            return CreatedAtAction(nameof(GetJobApplicationById), new { id = jobApplication.Id }, jobApplication);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateJobApplication(int id, [FromBody] JobApplication jobApplication)
        {
            if (id != jobApplication.Id)
            {
                return BadRequest();
            }

            _jobApplicationRepository.UpdateJobApplication(jobApplication);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteJobApplication(int id)
        {
            _jobApplicationRepository.DeleteJobApplication(id);
            return NoContent();
        }
    }
}
