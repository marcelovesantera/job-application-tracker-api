﻿namespace JobApplicationTrackerApi.Domain
{
    public class JobApplication
    {
        public JobApplication(string position, string company, decimal salary, string link, string platform, string contact, int phaseId, int statusId, DateTime applicationDate)
        {
            Position = position;
            Company = company;
            Salary = salary;
            Link = link;
            Platform = platform;
            Contact = contact;
            PhaseId = phaseId;
            StatusId = statusId;
            ApplicationDate = applicationDate;
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public string Position { get; set; }
        public string Company { get; set; }
        public decimal Salary { get; set; }
        public string Link { get; set; }
        public string Platform { get; set; }
        public string Contact { get; set; }
        public int PhaseId { get; set; }
        public JobApplicationPhase? Phase { get; set; }
        public int StatusId { get; set; }
        public JobApplicationStatus? Status { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
