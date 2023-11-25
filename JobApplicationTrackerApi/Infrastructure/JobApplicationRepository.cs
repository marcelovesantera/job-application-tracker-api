using JobApplicationTrackerApi.Domain;
using JobApplicationTrackerApi.Infrastructure.Interfaces;
using JobApplicationTrackerApi.Persistence;
using Microsoft.EntityFrameworkCore;

namespace JobApplicationTrackerApi.Infrastructure
{
    public class JobApplicationRepository : IJobApplicationRepository
    {
        private readonly ApplicationDbContext _context;

        public JobApplicationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<JobApplication> GetAllJobApplications()
        {
            return _context.JobApplications.ToList();
        }

        public JobApplication GetJobApplicationById(int jobId)
        {
            return _context.JobApplications.Find(jobId);
        }

        public void AddJobApplication(JobApplication jobApplication)
        {
            _context.JobApplications.Add(jobApplication);
            _context.SaveChanges();
        }

        public void UpdateJobApplication(JobApplication jobApplication)
        {
            _context.Entry(jobApplication).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteJobApplication(int jobId)
        {
            var jobApplication = _context.JobApplications.Find(jobId);
            if (jobApplication != null)
            {
                jobApplication.Deactivate();
                _context.Entry(jobApplication).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
}
