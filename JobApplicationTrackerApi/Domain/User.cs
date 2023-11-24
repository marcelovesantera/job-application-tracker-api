namespace JobApplicationTrackerApi.Domain
{
    public class User
    {
        public User(string name, string lastname, string email, string password, DateTime createdAt, bool isActive)
        {
            Name = name;
            Lastname = lastname;
            Email = email;
            Password = password;
            CreatedAt = DateTime.Now;
            IsActive = true;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
        public List<JobApplication>? JobApplications { get; set; }
    }
}
