namespace JobApplicationTrackerApi.Domain
{
    public class JobApplicationPhase
    {
        public JobApplicationPhase(string applicationPhase)
        {
            ApplicationPhase = applicationPhase;
        }

        public int Id { get; set; }
        public string ApplicationPhase { get; set; }
    }
}
