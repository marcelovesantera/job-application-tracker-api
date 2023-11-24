namespace JobApplicationTrackerApi.Domain
{
    public class JobApplicationStatus
    {
        public JobApplicationStatus(string applicationStatus)
        {
            ApplicationStatus = applicationStatus;
        }

        public int Id { get; set; }
        public string ApplicationStatus { get; set; }
    }
}
