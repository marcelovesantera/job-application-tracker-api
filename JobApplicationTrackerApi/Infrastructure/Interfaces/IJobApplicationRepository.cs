using JobApplicationTrackerApi.Domain;

namespace JobApplicationTrackerApi.Infrastructure.Interfaces
{
    public interface IJobApplicationRepository
    {
        List<JobApplication> GetAllJobApplications();
        JobApplication GetJobApplicationById(int jobId);
        void AddJobApplication(JobApplication jobApplication);
        void UpdateJobApplication(JobApplication jobApplication);
        void DeleteJobApplication(int jobId);
    }
}
