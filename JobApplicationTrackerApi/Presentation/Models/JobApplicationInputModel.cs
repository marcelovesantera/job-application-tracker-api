using JobApplicationTrackerApi.Domain;

namespace JobApplicationTrackerApi.Presentation.Models
{
    public class JobApplicationInputModel
    {
        public int UserId { get; set; }
        public string Position { get; set; }
        public string Company { get; set; }
        public decimal Salary { get; set; }
        public string Link { get; set; }
        public string Platform { get; set; }
        public string Contact { get; set; }
        public int PhaseId { get; set; }
        public int StatusId { get; set; }
        public DateTime ApplicationDate { get; set; }
    }
}
